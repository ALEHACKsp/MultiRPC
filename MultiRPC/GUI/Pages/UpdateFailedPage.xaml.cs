﻿using System;
using System.Windows;
using System.Windows.Controls;
using MultiRPC.Functions;

namespace MultiRPC.GUI.Pages
{
    /// <summary>
    /// Interaction logic for UpdateFailedPage.xaml
    /// </summary>
    public partial class UpdateFailedPage : Page
    {
        private long WindowID;
        public UpdateFailedPage(Exception e, long windowID)
        {
            InitializeComponent();
            WindowID = windowID;
            tblUpdateFailed.Text = App.Text.UpdateFailed;
            tblUpdateFailedMessage.Text = App.Text.UpdateFailedMessage;
            butRetryUpdate.Content = App.Text.RetryUpdate;
            butRetryOnNextStartUp.Content = App.Text.RetryOnNextStartUp;
            tbUpdateError.Text = e.Message;
            Title = App.Text.UpdateFailed;
        }

        private void ButRetryUpdate_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.CloseWindow(WindowID);
            Updater.Start();
        }

        private void ButRetryOnNextStartUp_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.CloseWindow(WindowID);
        }
    }
}
