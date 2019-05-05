using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleve;
using Tweetinvi.Models;

namespace TweetWPF.ViewModels
{
    public class TweetWPFViewModel : ViewModelBase
    {
        /// <summary></summary>
        private string _Message;
        public string Message
        {
            get { return _Message; }
            set
            {
                _Message = value;
                RaisePropertyChanged();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<ITweet> _Tweets = new ObservableCollection<ITweet>();
        public ObservableCollection<ITweet> Tweets
        {
            get { return _Tweets; }
            set { SetProperty(ref _Tweets, value); }
        }
    }
}
