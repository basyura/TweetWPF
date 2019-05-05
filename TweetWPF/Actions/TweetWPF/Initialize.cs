using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Eleve;

namespace TweetWPF.Actions.TweetWPF
{
    public class Initialize : TweetWPFActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object parameter)
        {
            return SuccessTask;
        }
    }
}
