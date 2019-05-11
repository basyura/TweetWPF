using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using Eleve;
using TweetWPF.Controls;

namespace TweetWPF.Actions.TweetWPF
{
    [ThreadMode(ThreadMode.Foreground)]
    public class ShowDetail : TweetWPFActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {
            TimelineView view = sender as TimelineView;

            Border border = view.Parent as Border;

            DetailView detail = new DetailView(view)
            {
                DataContext = ViewModel.SelectedTweet
            };

            border.Child = detail;



            return SuccessTask;
        }
    }
}
