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
    public partial class Config : Window
    {
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        
        public Config()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            this.Close();
        }

        private DateTime TimerStart { get; set; }

        public int ChInterval { get; set; }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            string interval = textBox.Text;
            int intv = String.IsNullOrEmpty(interval) ? 20 : int.Parse(interval);
            ChInterval = intv;

            MessageBox.Show("Notification will be shown in every " + interval + " minutes" );
            Notif notif = new Notif(this);
            this.TimerStart = DateTime.Now;
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, intv, 0);

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.Tick += timer_Tick;
            dispatcherTimer.Start();
            timer.Start();
            Timelbl.Content = intv + " minutes left";
            this.WindowState = WindowState.Minimized;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var currentValue =  (DateTime.Now - this.TimerStart);
            int x = ChInterval - int.Parse(currentValue.Minutes.ToString());
            Timelbl.Content = x + " minutes left" ;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            this.TimerStart = DateTime.Now;
            Notif notif = new Notif(this);
            notif.Show();
            
        }
    }
}
