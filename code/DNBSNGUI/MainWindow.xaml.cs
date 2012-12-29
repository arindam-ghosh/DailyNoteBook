﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace DNBSNGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MouseLeftButtonDown += delegate { this.DragMove(); };
        }

        private void kolkataBtn_Click(object sender, RoutedEventArgs e)
        {
            mapWb.NavigateToString("<html><body><iframe src=\"https://maps.google.co.in/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=kolkata+&amp;aq=&amp;sll=22.356426,88.211975&amp;sspn=0.779817,1.560059&amp;t=h&amp;ie=UTF8&amp;hq=&amp;hnear=Kolkata,+West+Bengal&amp;ll=22.356426,88.211975&amp;spn=24.657494,49.921875&amp;z=5&amp;output=embed\" width=\"1100\" height=\"480\" frameborder=\"0\" marginheight=\"0\" marginwidth=\"0\">Loading...</iframe></body></html>");
        }

        private void gcalenderBtn_Click(object sender, RoutedEventArgs e)
        {
            gCalenderWb.NavigateToString("<html><body><iframe src=\"https://www.facebook.com/connect/login_success.html#access_token=THE_TOKEN&expires_in=7180\" width=\"1100\" height=\"480\" frameborder=\"0\" marginheight=\"0\" marginwidth=\"0\">Loading...</iframe></body></html>");
            // fb like url https://www.facebook.com/plugins/like.php?href=https://www.facebook.com/technicise\

        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        private void virtualKeyboardDateBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //private void maximizeBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    this.WindowState = WindowState.Maximized;
        //}

        private void passwordMLoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((passwordMUserIdTB.Text.Equals("1")) && (passwordMPassBtnPB.Password.Equals("1")))
            {
                mainPassDP.IsEnabled = true;
                passwordMPassBtnPB.Password = string.Empty;
                loginpassPassExpndr.IsExpanded = false;
                loginpassPassExpndr.IsEnabled = false;
                loginpassPassExpndr.Header = "Logged In";
                loginpassPassExpndr.ToolTip = "Logged In";
                allDetailsExpndr.IsExpanded = true;
                logoutPassBtn.Content = "Logout";
                allDetailsExpndr.Header = "All Details";
                addInfoExpndr.Header = "Add Info";
                logoutPassBtn.IsEnabled = true;
            }
            else
            {
                //MessageBox.Show("Please Enter correct Password");
                DNBSNGUI.ErrorMessage ErrorMessageObj = new DNBSNGUI.ErrorMessage();
                ErrorMessageObj.ShowDialog();
                passwordMPassBtnPB.Password = string.Empty;
            }
        }

        private void logoutDnbsnBtn_Click(object sender, RoutedEventArgs e)
        {
            dNBSNUserIDTB.Text = string.Empty;
            dNBSNpassPB.Password = string.Empty;
            mainLeftExpndr.IsExpanded = false;
            mainLeftExpndr.IsEnabled = false;
            mainTabControl.IsEnabled = false;
            logoutDnbsnBtn.IsEnabled = false;
            logoutDnbsnBtn.Content = "";
            loginExpndr.IsExpanded = true;
            loginExpndr.IsEnabled = true;
            

        }

        private void dNBSNLoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((dNBSNUserIDTB.Text.Equals("1")) && (dNBSNpassPB.Password.Equals("1")))
            {
                mainLeftExpndr.IsEnabled = true;
                mainLeftExpndr.IsExpanded = true;
                dNBSNpassPB.Password = string.Empty;
                mainTabControl.IsEnabled = true;
                loginExpndr.IsEnabled = false;
                loginExpndr.Header = "Logged In";
                loginExpndr.IsExpanded = false;
                logoutDnbsnBtn.IsEnabled = true;
                logoutDnbsnBtn.Content = "LOG OUT";
                logoutDnbsnBtn.ToolTip = "log out";
            }
            else
            {
                //MessageBox.Show("Please Enter correct Password");
                DNBSNGUI.ErrorMessage ErrorMessageObj = new DNBSNGUI.ErrorMessage();
                ErrorMessageObj.ShowDialog();
                dNBSNpassPB.Password = string.Empty;
            }
        }

        private void logoutPassBtn_Click(object sender, RoutedEventArgs e)
        {
            mainPassDP.IsEnabled = false;
            passwordMPassBtnPB.Password = string.Empty;
            passwordMUserIdTB.Text = string.Empty;
            loginpassPassExpndr.IsExpanded = true;
            loginpassPassExpndr.IsEnabled = true;
            //loginpassPassExpndr.Header = "Logged In";
            //loginpassPassExpndr.ToolTip = "Logged In";
            allDetailsExpndr.IsExpanded = false;
            logoutPassBtn.Content = "Please Log In First";
            addInfoExpndr.Header = "Login To Add Info";
            allDetailsExpndr.Header = "Login To Show All Details";
            //allDetailsExpndr.Header = "All Details";
            //addInfoExpndr.Header = "Add Info";
            logoutPassBtn.IsEnabled = false;


            //mainLeftExpndr.IsEnabled = false;
            //mainLeftExpndr.IsExpanded = false;
            //dNBSNpassPB.Password = string.Empty;
            //mainTabControl.IsEnabled = false;
            //loginExpndr.IsEnabled = true;
            //loginExpndr.Header = "Logged In";
            //loginExpndr.IsExpanded = true;
        }
    }
}