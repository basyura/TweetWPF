using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Eleve;
using TweetWPF.Controls;

namespace TweetWPF.Actions.TweetWPF
{
    [ThreadMode(ThreadMode.Foreground)]
    public class BackToTimeline : TweetWPFActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {
            // todo : find view
            FrameworkElement ele = sender as FrameworkElement;
            while (!(ele is DetailView))
            {
                ele = ele.Parent as FrameworkElement;
            }

            DetailView detail = ele as DetailView;
            Grid grid = detail.Parent as Grid;
            grid.Children.Remove(detail);

            return SuccessTask;
        }
    }
}
