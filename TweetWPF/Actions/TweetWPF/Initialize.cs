using System;
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
            string tokenPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".config", "tweetwpf", "token.txt");
            string[] lines = File.ReadAllLines(tokenPath);

            Auth.SetUserCredentials(lines[0], lines[1], lines[2], lines[3]);

            IAuthenticatedUser user = User.GetAuthenticatedUser();
            if (user == null)
            {
                ViewModel.Message = "failed to authenticate.";
            }
            else
            {
                ViewModel.Message = user.ScreenName;
            }

            return SuccessTask;
        }
    }
}
