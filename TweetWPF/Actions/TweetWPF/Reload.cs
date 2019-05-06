using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eleve;
using Tweetinvi;
using Tweetinvi.Models;

namespace TweetWPF.Actions.TweetWPF
{
    /// <summary>
    /// 
    /// </summary>
    public class Reload : TweetWPFActionBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {
            string header = ViewModel.SelectedTabHeader;

            if (header == "Home")
            {
                ReloadHomeTimeline();
            }

            return SuccessTask;
        }
        /// <summary>
        /// 
        /// </summary>
        private void ReloadHomeTimeline()
        {
            IEnumerable<ITweet> tweets = Timeline.GetHomeTimeline();
            ITweet last = ViewModel.Tweets.FirstOrDefault();

            foreach (ITweet tweet in tweets.Reverse())
            {
                if (last == null)
                {
                    ViewModel.Tweets.Insert(0, tweet);
                    continue;
                }

                // todo : retweet

                if (last.CreatedAt < tweet.CreatedAt)
                {
                    ViewModel.Tweets.Insert(0, tweet);
                    continue;
                }
            }
        }
    }
}
