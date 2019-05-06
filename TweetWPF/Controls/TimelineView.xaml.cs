using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace TweetWPF.Controls
{
    /// <summary>
    /// TimelineView.xaml の相互作用ロジック
    /// </summary>
    public partial class TimelineView : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public TimelineView()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(
            "ItemsSource", typeof(IEnumerable), typeof(TimelineView), new PropertyMetadata(null, (d, e) => {
                TimelineView view = d as TimelineView;
                view.Timeline.ItemsSource = e.NewValue as IEnumerable;
            }));
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }
    }
}
