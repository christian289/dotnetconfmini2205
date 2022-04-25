using DevExpress.Mvvm.POCO;
using Microsoft.Extensions.DependencyInjection;

namespace dotnetconfmini2205_dxmvvmExam.VIewModels
{
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel => (MainWindowViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(MainWindowViewModel)));
        public AViewModel AViewModel => (AViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(AViewModel)));
        public BViewModel BViewModel => (BViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(BViewModel)));
        public CViewModel CViewModel => (CViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(CViewModel)));
    }
}
