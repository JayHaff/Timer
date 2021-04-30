namespace Timer.ViewModels
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Windows.Threading;

    using Caliburn.Micro;

    public class ShellViewModel : Screen
    {
        private readonly Stopwatch stopwatch1;

        private readonly Stopwatch stopwatch2;

        private readonly Stopwatch stopwatch3;

        private readonly Stopwatch stopwatch4;

        private bool _enableResetTimer1;

        private bool _enableResetTimer2;

        private bool _enableResetTimer3;

        private bool _enableResetTimer4;

        private string _hours1;

        private string _hours2;

        private string _hours3;

        private string _hours4;

        private string _startTimer1Width;

        private string _startTimer2Width;

        private string _startTimer3Width;

        private string _startTimer4Width;

        private string _stopTimer1Width;

        private string _stopTimer2Width;

        private string _stopTimer3Width;

        private string _stopTimer4Width;

        private string _timer1;

        private string _timer2;

        private string _timer3;

        private string _timer4;

        private DispatcherTimer timer;

        public ShellViewModel()
        {
            stopwatch1 = new Stopwatch();
            stopwatch2 = new Stopwatch();
            stopwatch3 = new Stopwatch();
            stopwatch4 = new Stopwatch();

            _startTimer1Width = "75";
            _startTimer2Width = "75";
            _startTimer3Width = "75";
            _startTimer4Width = "75";

            _stopTimer1Width = "0";
            _stopTimer2Width = "0";
            _stopTimer3Width = "0";
            _stopTimer4Width = "0";

            Timer1 = string.Format("{0:hh\\:mm\\:ss}", stopwatch1.Elapsed);
            Hours1 = CalculateHours(stopwatch1);

            Timer2 = string.Format("{0:hh\\:mm\\:ss}", stopwatch1.Elapsed);
            Hours2 = CalculateHours(stopwatch2);

            Timer3 = string.Format("{0:hh\\:mm\\:ss}", stopwatch3.Elapsed);
            Hours3 = CalculateHours(stopwatch2);

            Timer3 = string.Format("{0:hh\\:mm\\:ss}", stopwatch4.Elapsed);
            Hours3 = CalculateHours(stopwatch2);

            Timer4 = string.Format("{0:hh\\:mm\\:ss}", stopwatch4.Elapsed);
            Hours4 = CalculateHours(stopwatch2);

            Timer4 = string.Format("{0:hh\\:mm\\:ss}", stopwatch4.Elapsed);
            Hours4 = CalculateHours(stopwatch4);
        }

        public bool EnableResetTimer1
        {
            get
            {
                return _enableResetTimer1;
            }
            set
            {
                _enableResetTimer1 = value;

                NotifyOfPropertyChange(() => EnableResetTimer1);
            }
        }

        public bool EnableResetTimer2
        {
            get
            {
                return _enableResetTimer2;
            }
            set
            {
                _enableResetTimer2 = value;

                NotifyOfPropertyChange(() => EnableResetTimer2);
            }
        }

        public bool EnableResetTimer3
        {
            get
            {
                return _enableResetTimer3;
            }
            set
            {
                _enableResetTimer3 = value;

                NotifyOfPropertyChange(() => EnableResetTimer3);
            }
        }

        public bool EnableResetTimer4
        {
            get
            {
                return _enableResetTimer4;
            }
            set
            {
                _enableResetTimer4 = value;

                NotifyOfPropertyChange(() => EnableResetTimer4);
            }
        }

        public string Hours1
        {
            get
            {
                return _hours1;
            }

            set
            {
                _hours1 = value;
                NotifyOfPropertyChange(() => Hours1);
            }
        }

        public string Hours2
        {
            get
            {
                return _hours2;
            }

            set
            {
                _hours2 = value;
                NotifyOfPropertyChange(() => Hours2);
            }
        }

        public string Hours3
        {
            get
            {
                return _hours3;
            }

            set
            {
                _hours3 = value;
                NotifyOfPropertyChange(() => Hours3);
            }
        }

        public string Hours4
        {
            get
            {
                return _hours4;
            }

            set
            {
                _hours4 = value;
                NotifyOfPropertyChange(() => Hours4);
            }
        }

        public string StartTimer1Width
        {
            get
            {
                return _startTimer1Width;
            }
            set
            {
                _startTimer1Width = value;

                NotifyOfPropertyChange(() => StartTimer1Width);
            }
        }

        public string StartTimer2Width
        {
            get
            {
                return _startTimer2Width;
            }
            set
            {
                _startTimer2Width = value;

                NotifyOfPropertyChange(() => StartTimer2Width);
            }
        }

        public string StartTimer3Width
        {
            get
            {
                return _startTimer3Width;
            }
            set
            {
                _startTimer3Width = value;

                NotifyOfPropertyChange(() => StartTimer3Width);
            }
        }

        public string StartTimer4Width
        {
            get
            {
                return _startTimer4Width;
            }
            set
            {
                _startTimer4Width = value;

                NotifyOfPropertyChange(() => StartTimer4Width);
            }
        }

        public string StopTimer1Width
        {
            get
            {
                return _stopTimer1Width;
            }
            set
            {
                _stopTimer1Width = value;

                NotifyOfPropertyChange(() => StopTimer1Width);
            }
        }

        public string StopTimer2Width
        {
            get
            {
                return _stopTimer2Width;
            }
            set
            {
                _stopTimer2Width = value;

                NotifyOfPropertyChange(() => StopTimer2Width);
            }
        }

        public string StopTimer3Width
        {
            get
            {
                return _stopTimer3Width;
            }
            set
            {
                _stopTimer3Width = value;

                NotifyOfPropertyChange(() => StopTimer3Width);
            }
        }

        public string StopTimer4Width
        {
            get
            {
                return _stopTimer4Width;
            }
            set
            {
                _stopTimer4Width = value;

                NotifyOfPropertyChange(() => StopTimer4Width);
            }
        }

        public string Timer1
        {
            get
            {
                return _timer1;
            }

            set
            {
                _timer1 = value;
                NotifyOfPropertyChange(() => Timer1);
            }
        }

        public string Timer2
        {
            get
            {
                return _timer2;
            }

            set
            {
                _timer2 = value;
                NotifyOfPropertyChange(() => Timer2);
            }
        }

        public string Timer3
        {
            get
            {
                return _timer3;
            }

            set
            {
                _timer3 = value;
                NotifyOfPropertyChange(() => Timer3);
            }
        }

        public string Timer4
        {
            get
            {
                return _timer4;
            }

            set
            {
                _timer4 = value;
                NotifyOfPropertyChange(() => Timer4);
            }
        }

        public void ResetTimer1()
        {
            stopwatch1.Reset();
            Hours1 = CalculateHours(stopwatch1);
            Timer1 = string.Format("{0:hh\\:mm\\:ss}", stopwatch1.Elapsed);
            timer.Stop();
            EnableResetTimer1 = false;
            StopTimer1Width = "0";
        }

        public void ResetTimer2()
        {
            stopwatch2.Reset();
            Hours2 = CalculateHours(stopwatch2);
            Timer2 = string.Format("{0:hh\\:mm\\:ss}", stopwatch2.Elapsed);
            timer.Stop();
            EnableResetTimer2 = false;
            StopTimer2Width = "0";
        }

        public void ResetTimer3()
        {
            stopwatch3.Reset();
            Hours3 = CalculateHours(stopwatch3);
            Timer3 = string.Format("{0:hh\\:mm\\:ss}", stopwatch3.Elapsed);
            timer.Stop();
            EnableResetTimer3 = false;
            StopTimer3Width = "0";
        }

        public void ResetTimer4()
        {
            stopwatch4.Reset();
            Hours4 = CalculateHours(stopwatch4);
            Timer4 = string.Format("{0:hh\\:mm\\:ss}", stopwatch4.Elapsed);
            timer.Stop();
            EnableResetTimer4 = false;
            StopTimer4Width = "0";
        }

        public void StartTimer1()
        {
            stopwatch1.Start();
            StartClock();
            StartTimer1Width = "0";
            StopTimer1Width = "75";
            EnableResetTimer1 = false;
        }

        public void StartTimer2()
        {
            stopwatch2.Start();
            StartClock();
            StartTimer2Width = "0";
            StopTimer2Width = "75";
            EnableResetTimer2 = false;
        }

        public void StartTimer3()
        {
            stopwatch3.Start();
            StartClock();
            StartTimer3Width = "0";
            StopTimer3Width = "75";
            EnableResetTimer3 = false;
        }

        public void StartTimer4()
        {
            stopwatch4.Start();
            StartClock();
            StartTimer4Width = "0";
            StopTimer4Width = "75";
            EnableResetTimer4 = false;
        }

        public void StopTimer1()
        {
            timer.Stop();
            stopwatch1.Stop();
            EnableResetTimer1 = true;
            StartTimer1Width = "75";
            StopTimer1Width = "0";
        }

        public void StopTimer2()
        {
            timer.Stop();
            stopwatch2.Stop();
            EnableResetTimer2 = true;
            StartTimer2Width = "75";
            StopTimer2Width = "0";
        }

        public void StopTimer3()
        {
            timer.Stop();
            stopwatch3.Stop();
            EnableResetTimer3 = true;
            StartTimer3Width = "75";
            StopTimer3Width = "0";
        }

        public void StopTimer4()
        {
            timer.Stop();
            stopwatch4.Stop();
            EnableResetTimer4 = true;
            StartTimer4Width = "75";
            StopTimer4Width = "0";
        }

        private string CalculateHours(Stopwatch watch)
        {
            return Math.Round(watch.Elapsed.TotalSeconds / 3600, 2).ToString(CultureInfo.InvariantCulture);
        }

        private void StartClock()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TickEvent;
            timer.Start();
        }

        private void TickEvent(object sender, EventArgs e)
        {
            Timer1 = string.Format("{0:hh\\:mm\\:ss}", stopwatch1.Elapsed);
            Hours1 = CalculateHours(stopwatch1);

            Timer2 = string.Format("{0:hh\\:mm\\:ss}", stopwatch2.Elapsed);
            Hours2 = CalculateHours(stopwatch2);

            Timer3 = string.Format("{0:hh\\:mm\\:ss}", stopwatch3.Elapsed);
            Hours3 = CalculateHours(stopwatch3);

            Timer4 = string.Format("{0:hh\\:mm\\:ss}", stopwatch4.Elapsed);
            Hours4 = CalculateHours(stopwatch4);
        }
    }
}