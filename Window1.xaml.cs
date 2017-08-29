using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        
        public Window1()
        {
            InitializeComponent();
            Notif notif = new Notif(this);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            this.Close();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            string interval = textBox.Text;
            int intv = int.Parse(interval);

            MessageBox.Show("Notification will be shown in every " + interval + " minutes" );
            Notif notif = new Notif(this);
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, intv);
            dispatcherTimer.Start();

            this.WindowState = WindowState.Minimized;
        }
        
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            //this.WindowState = WindowState.Normal;
            //MessageBox.Show("Time for a break!");
            //this.WindowState = WindowState.Minimized;
            Notif notif = new Notif(this);
            notif.Show();
            
            //Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
            //{
            //    var workingArea = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea;
            //    var transform = PresentationSource.FromVisual(this).CompositionTarget.TransformFromDevice;
            //    var corner = transform.Transform(new Point(workingArea.Right, workingArea.Bottom));

            //    this.Left = corner.X - this.ActualWidth - 100;
            //    this.Top = corner.Y - this.ActualHeight;
            //}));
        }
    }
}
