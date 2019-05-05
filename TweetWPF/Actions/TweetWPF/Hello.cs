using System;
using System.Threading.Tasks;
using Eleve;

namespace TweetWPF.Actions.TweetWPF
{
    public class Hello : TweetWPFActionBase
    {
        public override Task<ActionResult> Execute(object sender, EventArgs args, object obj)
        {
            ViewModel.Message = "World";

            return SuccessTask;
        }
    }
}