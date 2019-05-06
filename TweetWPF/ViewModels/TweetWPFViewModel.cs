using System.Collections.ObjectModel;
using System.Windows.Data;
using Eleve;
using Tweetinvi.Models;

namespace TweetWPF.ViewModels
{
    public class TweetWPFViewModel : ViewModelBase
    {
        /// <summary>
        /// 
        /// </summary>
        public TweetWPFViewModel()
        {
            BindingOperations.EnableCollectionSynchronization(_Tweets, new object());
            BindingOperations.EnableCollectionSynchronization(_Mentions, new object());
        }
        /// <summary></summary>
        private string _Message;
        public string Message
        {
            get { return _Message; }
            set { SetProperty(ref _Message, value); }
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
        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<ITweet> _Mentions = new ObservableCollection<ITweet>();
        public ObservableCollection<ITweet> Mentions
        {
            get { return _Mentions; }
            set { SetProperty(ref _Mentions, value); }
        }
    }
}
