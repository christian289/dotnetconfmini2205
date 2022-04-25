using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using dotnetconfmini2205_dxmvvmExam.VIewModels;
using dotnetconfmini2205_dxmvvmExam.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace dotnetconfmini2205_dxmvvmExam
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost host;

        public static IServiceProvider ServiceProvider { get; private set; }

        public App()
        {
            Messenger.Default = new Messenger(isMultiThreadSafe: true, actionReferenceType: ActionReferenceType.WeakReference);

            host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {
                    service.AddScoped(ViewModelSource.GetPOCOType(typeof(MainWindowViewModel)));
                    service.AddScoped(ViewModelSource.GetPOCOType(typeof(AViewModel)));
                    service.AddScoped(ViewModelSource.GetPOCOType(typeof(BViewModel)));
                    service.AddScoped(ViewModelSource.GetPOCOType(typeof(CViewModel)));
                    // AddTransient로 하면 ViewModel이 유지가 되지 않아서 데이터가 새로 발생하게 되어 갱신되는 것처럼 보임.
                    //service.AddTransient(ViewModelSource.GetPOCOType(typeof(ListProgressViewModel)));
                    //service.AddTransient(ViewModelSource.GetPOCOType(typeof(CalenderProgressViewModel)));
                    // AddScoped로 하면 ViewModel은 유지가 되고 View는 새로 생성되어 데이터가 유지됨.
                })
                .Build();

            ServiceProvider = host.Services;
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await host.StartAsync();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            using (host)
            {
                await host.StopAsync(TimeSpan.FromSeconds(5));
            }

            base.OnExit(e);
        }
    }
}
