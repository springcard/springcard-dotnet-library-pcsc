using Avalonia.Controls;
using Avalonia.Input;

namespace SpringCard.PCSC.UI.Controls.ReaderSelect;

public partial class ReaderSelectWindow : Window
{
    public ReaderSelectWindow()
    {
        InitializeComponent();
    }

    private void ListBox_PointerPressed(object? sender, PointerPressedEventArgs e)
    {
        if (e.ClickCount == 2 && DataContext is ReaderSelectViewModel viewModel)
        {
            viewModel.ConfirmSelection();
        }
    }
}