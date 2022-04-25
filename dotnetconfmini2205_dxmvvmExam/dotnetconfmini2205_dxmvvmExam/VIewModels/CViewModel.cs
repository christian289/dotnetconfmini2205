using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using dotnetconfmini2205_dxmvvmExam.MessengerType;

namespace dotnetconfmini2205_dxmvvmExam.VIewModels
{
    [POCOViewModel]
    public class CViewModel
    {
        public CViewModel()
        {
            Messenger.Default.Register<AtoBC>(this, TextCallbackByA);
            Messenger.Default.Register<BtoAC>(this, TextCallbackByB);
        }

        public virtual string TextA { get; set; }

        public virtual string TextB { get; set; }

        public void Send()
        {
            Messenger.Default.Send(new CtoAB
            {
                SendMessage = "C에서 A,B로 보냅니다. 빵야빵야!"
            });
        }

        [Command(isCommand: false)]
        public void TextCallbackByA(AtoBC msg)
        {
            TextA = msg.SendMessage;
        }

        [Command(isCommand: false)]
        public void TextCallbackByB(BtoAC msg)
        {
            TextB = msg.SendMessage;
        }
    }
}
