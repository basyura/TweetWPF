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

            Grid grid = view.Parent as Grid;

            DetailView detail = new DetailView()
            {
                DataContext = ViewModel.SelectedTweet
            };

            grid.Children.Add(detail);

            return SuccessTask;
        }
    }
}
