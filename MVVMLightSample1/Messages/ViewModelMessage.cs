using GalaSoft.MvvmLight.Messaging;

namespace MVVMLightSample1.Messages
{
    public class ViewModelMessage : MessageBase
    {
        public string Text { get; set; }
    }
}