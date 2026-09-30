using DynamicData;
using SpringCard.LibCs.Windows.ApplicationConfiguration;
using SpringCard.LibCs.Windows.UI.Services.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace SpringCard.PCSC.UI.Controls.ReaderSelect;

public class ReaderSelectViewModel : WindowViewModel, INotifyPropertyChanged
{
    /// <summary>
    /// Set this property to preselect a reader by name.<br/>
    /// If not set, the last reader used will be preselected if available.
    /// </summary>
    public string? PreselectedReaderName { get; init; }
    /// <summary>
    /// Set this property to ignore some readers when building the list.
    /// </summary>
    public IEnumerable<string> ReadersToIgnore { get; init; } = [];
    /// <summary>
    /// Set this property to true to show the remember checkbox.
    /// </summary>
    public bool IsRememberVisible { get; init; }

    public bool IsRememberChecked { get; internal set; }
    public ObservableCollection<string> Readers { get; internal set; } = [];
    public string? SelectedReader
    {
        get => _selectedReader;
        internal set
        {
            _selectedReader = value;
            OnPropertyChanged(nameof(SelectedReader));
        }
    }

    public new event PropertyChangedEventHandler? PropertyChanged;

    private readonly IWritableOptions<ReaderSelectConfiguration>? _settings;
    private string? _selectedReader;

    public ReaderSelectViewModel() => RefreshReaders();
    public ReaderSelectViewModel(IWritableOptions<ReaderSelectConfiguration> settings)
    {
        _settings = settings;
        IsRememberChecked = settings.Value.IsRememberChecked;

        if (string.IsNullOrEmpty(PreselectedReaderName))
            PreselectedReaderName = settings.Value.SelectedReader;

        RefreshReaders();
    }

    public void RefreshReaders()
    {
        var mask = ReadersToIgnore ?? [];

        if (mask.Any())
            SCARD.SCardLogger.trace("Building reader list (discard={0})", string.Join('|', mask));
        else
            SCARD.SCardLogger.trace("Building reader list");

        var currentReaders = SCARD.Readers
            .Where(r => !mask.Contains(r))
            .OrderBy(r => r)
            .ToList();

        Readers.Where(x => !currentReaders.Contains(x)).ToList().ForEach(x => Readers.Remove(x));
        Readers.AddRange(currentReaders.Where(r => !Readers.Contains(r)));
    }

    public void ConfirmSelection()
    {
        if (IsRememberVisible)
            _settings?.Update(x => x.IsRememberChecked = IsRememberChecked);

        if (SelectedReader != null)
        {
            _settings?.Update(x => x.SelectedReader = SelectedReader);

            Close(SelectedReader);
        }
    }

    public void Cancel() => Close(string.Empty);

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        if (propertyName == nameof(IsRememberVisible))
            HandleIsRememberVisibleChanged();
    }

    private void HandleIsRememberVisibleChanged()
    {
        if (IsRememberVisible && IsRememberChecked
            && !string.IsNullOrEmpty(PreselectedReaderName)
            && Readers.Contains(PreselectedReaderName))
        {
            SelectedReader = PreselectedReaderName;
        }
    }
}
