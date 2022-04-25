using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using dotnetconfmini2205_dxmvvmExam.MessengerType;

namespace dotnetconfmini2205_dxmvvmExam.VIewModels
{
    [POCOViewModel]
    public class AViewModel
    {
        public AViewModel()
        {
            Messenger.Default.Register<BtoAC>(this, TextCallbackByB);
            Messenger.Default.Register<CtoAB>(this, TextCallbackByC);
        }

        public virtual string TextB { get; set; }

        public virtual string TextC { get; set; }

        public void Send()
        {
            Messenger.Default.Send(new AtoBC
            {
                SendMessage = "A에서 B,C로 보냅니다. 빵야빵야!"
            });
        }

        [Command(isCommand: false)]
        public void TextCallbackByB(BtoAC msg)
        {
            TextB = msg.SendMessage;
        }

        [Command(isCommand: false)]
        public void TextCallbackByC(CtoAB msg)
        {
            TextC = msg.SendMessage;
        }
    }
}
