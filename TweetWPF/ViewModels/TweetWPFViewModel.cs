﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleve;

namespace TweetWPF.ViewModels
{
    public class TweetWPFViewModel : ViewModelBase
    {
        /// <summary></summary>
        private string _Message;
        public string Message
        {
            get { return _Message; }
            set
            {
                _Message = value;
                RaisePropertyChanged();
            }
        }
    }
}
