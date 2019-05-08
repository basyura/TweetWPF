using System;
using System.Windows;
using System.Threading.Tasks;
using Eleve;
using Tweetinvi.Models;

namespace TweetWPF.Actions.TweetWPF
{
    public class SelectTweetMenu : TweetWPFActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {
            string key = obj as string;
            if (string.IsNullOrEmpty(key))
            {
                return SuccessTask;
            }

            ITweet tweet = ViewModel.SelectedTweet;
            if (tweet == null)
            {
                return SuccessTask;
            }

            return SuccessTask;
        }
    }
}
