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
        public override Task<ActionResult> Execute(object sender, EventArgs args, object parameter)
        {
            IAuthenticatedUser user = Authenticate();

            if (user == null)
            {
                ViewModel.Message = "failed to authenticate.";
            }
            else
            {
                ViewModel.Message = user.ScreenName;
            }

            IEnumerable<ITweet> tweets = Timeline.GetHomeTimeline();
            foreach (ITweet tweet in tweets)
            {
                ViewModel.Tweets.Add(tweet);
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
