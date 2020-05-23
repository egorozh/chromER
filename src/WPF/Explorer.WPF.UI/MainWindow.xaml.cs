﻿using Explorer.Shared.ViewModels;
using System.ComponentModel;
using System.Windows;

namespace Explorer.WPF.UI
{
    public partial class MainWindow
    {
        private readonly MainViewModel _mainVm;

        public MainWindow()
        {
            InitializeComponent();

            _mainVm = new MainViewModel();

            DataContext = _mainVm;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _mainVm.ApplicationClosing();

            Application.Current.Shutdown();
        }
    }
}