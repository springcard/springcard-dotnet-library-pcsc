using Avalonia;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SpringCard.LibCs.Windows.ApplicationConfiguration;
using SpringCard.LibCs.Windows.UI;
using SpringCard.LibCs.Windows.UI.IoC;
using SpringCard.LibCs.Windows.UI.Services.Windows;
using SpringCard.PCSC.UI.Controls.ReaderSelect;
using System;

namespace Test.UI;

public partial class App : Application
{
    private readonly IServiceProvider _services;

    public App()
    {
        var defaultApplicationSettings = new ReaderSelectConfiguration();

        var configuration = new ConfigurationBuilder()
            .AddSpringCardJsonFile([defaultApplicationSettings], false, true)
            .Build();

        _services = new ServiceCollection()
            .AddSpringCardLogger(LogLevel.Trace)
            .AddSpringCardUI()
            .AddTransient<ReaderSelectViewModel>()
            .ConfigureSpringCardOptions<ReaderSelectConfiguration>(configuration)
            .BuildServiceProvider();
    }

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var windowService = _services.GetRequiredService<IWindowService>();
        _ = windowService.ShowDialogAsync<ReaderSelectWindow, ReaderSelectViewModel, string>();

        base.OnFrameworkInitializationCompleted();
    }
}
