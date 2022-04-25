using DevExpress.Mvvm.DataAnnotations;
using System.Diagnostics;

namespace dotnetconfmini2205_dxmvvmExam.VIewModels
{
    [POCOViewModel]
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {

        }

        public void OnMainWindowLoaded()
        {
            Debug.WriteLine("MainWindow에서 Loaded 이벤트 발생!!");
        }
    }
}
