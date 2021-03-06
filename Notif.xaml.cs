﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SaveEyes
{
    /// <summary>
    /// Interaction logic for Notif.xaml
    /// </summary>
    public partial class Notif : Window
    {
        public Notif(Window parent)
        {
            InitializeComponent();
            Application.Current.MainWindow.Topmost = true;

            Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(async () =>
            {
                //var workingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
                //var presentationSource = PresentationSource.FromVisual(parent);
                //var compositeTarget = presentationSource.CompositionTarget;
                //var transform = compositeTarget.TransformFromDevice;
                //var corner = transform.Transform(new Point(workingArea.Right, workingArea.Bottom));

                //this.Left = corner.X - this.ActualWidth - 100;
                //this.Top = corner.Y - this.ActualHeight;
                double height = SystemParameters.WorkArea.Height;
                double width = SystemParameters.WorkArea.Width;
                this.Top = (height - this.Height) / 2;
                this.Left = (width - this.Width) / 2;

                SystemSounds.Hand.Play();
                await Task.Delay(2000);
                this.Close();
            }));

            

        }

        private void Dismiss_Click(object sender, RoutedEventArgs e) {

            this.Close();
        }
    }
}
