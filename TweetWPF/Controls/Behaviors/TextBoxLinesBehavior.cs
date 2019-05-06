using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace TweetWPF.Controls.Behaviors
{
    public class TextBoxLinesBehavior : Behavior<TextBox>
    {
        /// <summary>
        /// 
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.GotFocus += AssociatedObject_GotFocus;
            AssociatedObject.LostFocus += AssociatedObject_LostFocus;
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.Loaded -= AssociatedObject_GotFocus;
            AssociatedObject.LostFocus -= AssociatedObject_LostFocus;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssociatedObject_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox text = sender as TextBox;
            text.MinHeight = 45;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssociatedObject_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox text = sender as TextBox;
            text.MinHeight = 0;
        }
    }
}
