using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using MVVMLightSample1.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightSample1.ViewModel
{
    // 2019-03-07-01 블로그에 소스가 없네... (https://hongal.tistory.com/71)
    // 2019-03-07-02 찾았다. (https://sirars.wordpress.com/tag/mvvm-light-toolkit/)
    public class ReceiverViewModel : ViewModelBase
    {
        private string _contentText;

        public string ContentText
        {
            get { return _contentText; }
            set
            {
                _contentText = value;
                RaisePropertyChanged("ContentText");
            }
        }

        public ReceiverViewModel()
        {
            Messenger.Default.Register<ViewModelMessage>(this, OnReceiveMessageAction);
        }

        private void OnReceiveMessageAction(ViewModelMessage obj)
        {
            ContentText = obj.Text;
        }
    }
}
