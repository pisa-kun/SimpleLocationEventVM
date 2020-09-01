using GalaSoft.MvvmLight;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LocationChanged
{
    public class MainWindowViewModel : BindableBase
    {
        /// <summary>
        /// viewのwindow情報
        /// </summary>
        private Window mainWindow;

        private string messageTop;
        public string MessageTop
        {
            get { return messageTop; }
            set { this.SetProperty(ref this.messageTop, value); }
        }

        private string messageLeft;
        public string MessageLeft
        {
            get { return messageLeft; }
            set { this.SetProperty(ref this.messageLeft, value); }
        }

        /// <summary>
        /// object sender, EventArgs e は不要
        /// DelegateCommandをBinding
        /// </summary>
        public DelegateCommand LocationChangedCommand { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindowViewModel(Window window)
        {
            this.mainWindow = window;
            LocationChangedCommand = new DelegateCommand(() => 
            {
                MessageTop = $"now Top :{mainWindow.Top}px";
                MessageLeft = $"now Left :{mainWindow.Left}px";
            }) ;

        }

    }
}
