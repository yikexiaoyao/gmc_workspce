using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using gmc_v_2_0.ViewModels;

namespace gmc_v_2_0.Views
{
    public class MessageResult
    {
        /// <summary>
        /// 结果，Yes为true，No为false
        /// </summary>
        public bool IsYes { get; set; }
        public TimeSpan YesLeftTime { get; set; }

        public TimeSpan NoLeftTime { get; set; }
    }
    public class MessageBoxEventArgs : EventArgs
    {
        /// <summary>
        /// 结果，Yes为true，No为false
        /// </summary>
        public MessageResult Result { get; set; }
    }
    /// <summary>
    /// MessageBox.xaml 的交互逻辑
    /// </summary>
    public partial class MessageBox : Window, INotifyPropertyChanged
    {
        public  event EventHandler<MessageBoxEventArgs> Result;
        public event PropertyChangedEventHandler PropertyChanged;
        string _context = "Ensure?";
        public string Context
        {
            get { return _context; }
            set { _context = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Context")); }
        }

        string _yesText = "Yes";
        public string YesText
        {
            get { return _yesText; }
            set { _yesText = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("YesText")); }
        }
        string _noText = "No";
        public string NoText
        {
            get { return _noText; }
            set { _noText = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NoText")); }
        }

        TimeSpan _yesLeftTime = TimeSpan.FromSeconds(-1);
        public TimeSpan YesLeftTime
        {
            get { return _yesLeftTime; }
            set { _yesLeftTime = value; PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("YesLeftTime"));}
        }
        TimeSpan _noLeftTime= TimeSpan.FromSeconds(-1);
        public TimeSpan NoLeftTime
        {
            get { return _noLeftTime; }
            set { _noLeftTime = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NoLeftTime")); }
        }
        bool _isLegal = false;
        DispatcherTimer _timer;
        public MessageBox()
        {
            InitializeComponent();
            DataContext = this;

        }
        public static void Show(string context, EventHandler<MessageBoxEventArgs> result)
        {
            var mb = new MessageBox();
            mb.Context = context;
            mb.Result += result;
            mb.Show();
        }

        public static MessageResult ShowDialog(string context)
        {
            return ShowDialog(context,null,null, null, null);
        }
        public static MessageResult ShowDialog(string context, string yesText, string noText)
        {
            return ShowDialog(context, yesText, noText, null, null);
        }
        public static void Toast(string context, TimeSpan stayTime)
        {
          App.Current.Dispatcher.BeginInvoke(new Action(()=> {
              ShowDialog(context, null, null, stayTime, null);
          }));
        }

        public static MessageResult ShowDialog(string context,TimeSpan ?yestCountDown, TimeSpan? noCountDown)
        {
            return ShowDialog(context, null, null, yestCountDown, noCountDown);
        }

        public static MessageResult ShowDialog(string context,string yesText,string noText ,TimeSpan? yestCountDown, TimeSpan? noCountDown)
        {
            var mb = new MessageBox();
            mb.Context = context;
            MessageResult r = null;
            mb.YesText = yesText;
            mb.NoText = noText;
            if (yestCountDown != null)
            {
                mb.YesLeftTime = yestCountDown.Value;
            }
            if (noCountDown != null)
            {
                mb.NoLeftTime = noCountDown.Value;
            }
            mb.Result += (s, e) => {
                r = e.Result;
            };
            mb.ShowDialog();
            return r;
        }


        private void No_Button_Click(object sender, RoutedEventArgs e)
        {
            _isLegal = true;
            Close();
            Result?.Invoke(this, new MessageBoxEventArgs() { Result = new MessageResult() { IsYes=false, YesLeftTime=this.YesLeftTime, NoLeftTime= this.NoLeftTime } });
        }
        private void Yes_Button_Click(object sender, RoutedEventArgs e)
        {
            _isLegal = true;
            Close();
            Result?.Invoke(this, new MessageBoxEventArgs() { Result = new MessageResult() { IsYes = true, YesLeftTime = this.YesLeftTime, NoLeftTime = this.NoLeftTime } });
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !_isLegal;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(YesLeftTime.TotalSeconds>0||NoLeftTime.TotalSeconds > 0)
            {
                _timer = new DispatcherTimer();
                _timer.Interval = TimeSpan.FromSeconds(1);
                _timer.Tick += (S, E) =>
                {
                    if (YesLeftTime.TotalSeconds > 0)
                    {
                        YesLeftTime = YesLeftTime.Add(-TimeSpan.FromSeconds(1));
                    }
                    else if (YesLeftTime.TotalSeconds == 0)
                    {
                        _timer.Stop();
                        Yes_Button_Click(null, null);
                    }
                    if (NoLeftTime.TotalSeconds > 0)
                    {
                        NoLeftTime = NoLeftTime.Add(-TimeSpan.FromSeconds(1));
                    }
                    else if (NoLeftTime.TotalSeconds == 0)
                    {
                        _timer.Stop();
                        No_Button_Click(null, null);
                    }
                };
                _timer.Start();
            }
        }
    }
}