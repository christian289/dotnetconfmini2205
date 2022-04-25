using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using dotnetconfmini2205_dxmvvmExam.MessengerType;

namespace dotnetconfmini2205_dxmvvmExam.VIewModels
{
    [POCOViewModel]
    public class BViewModel
    {
        public BViewModel()
        {
            Messenger.Default.Register<AtoBC>(this, TextCallbackByA);
            Messenger.Default.Register<CtoAB>(this, TextCallbackByC);
        }

        public virtual string TextA { get; set; }

        public virtual string TextC { get; set; }

        public void Send()
        {
            Messenger.Default.Send(new BtoAC
            {
                SendMessage = "B에서 A,C로 보냅니다. 빵야빵야!"
            });
        }

        [Command(isCommand: false)]
        public void TextCallbackByA(AtoBC msg)
        {
            TextA = msg.SendMessage;
        }

        [Command(isCommand: false)]
        public void TextCallbackByC(CtoAB msg)
        {
            TextC = msg.SendMessage;
        }
    }
}
