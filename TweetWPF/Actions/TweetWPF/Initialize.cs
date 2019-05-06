using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Eleve;
using Tweetinvi;
using Tweetinvi.Models;

namespace TweetWPF.Actions.TweetWPF
{
    public class Initialize : TweetWPFActionBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public override Task<ActionResult> Execute(object sender, EventArgs args, object parameter)
        {
            IAuthenticatedUser user = Authenticate();
            if (user == null)
            {
                ViewModel.Message = "failed to authenticate.";
                return SuccessTask;
            }

            ViewModel.User = user;

            IEnumerable<ITweet> tweets = Timeline.GetHomeTimeline();
            foreach (ITweet tweet in tweets)
            {
                ViewModel.Tweets.Add(tweet);
            }

            IEnumerable<ITweet> mentions = Timeline.GetMentionsTimeline();
            foreach (ITweet mention in mentions)
            {
                ViewModel.Mentions.Add(mention);
            }

            return SuccessTask;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private IAuthenticatedUser Authenticate()
        {
            string tokenPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".config", "tweetwpf", "token.txt");
            string[] lines = File.ReadAllLines(tokenPath);

            Auth.SetUserCredentials(lines[0], lines[1], lines[2], lines[3]);

            IAuthenticatedUser user = User.GetAuthenticatedUser();

            return user;
        }
    }
}
