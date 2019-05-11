using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            FrameworkElement ele = sender as FrameworkElement;
            while (!(ele is DetailView))
            {
                ele = ele.Parent as FrameworkElement;
            }

            DetailView detail = ele as DetailView;
            Border border = detail.Parent as Border;
            border.Child = detail.TimelineView;

            return SuccessTask;
        }
    }
}
