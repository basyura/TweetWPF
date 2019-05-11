﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TweetWPF.Controls
{
    /// <summary>
    /// DetailView.xaml の相互作用ロジック
    /// </summary>
    public partial class DetailView : UserControl
    {
        public DetailView(TimelineView view)
        {
            InitializeComponent();
            TimelineView = view;
        }

        public TimelineView TimelineView { get; private set; }
    }
}
