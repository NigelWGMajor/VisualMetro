using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Windows;


namespace Nix.Metro
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            X = Y = _scale = 150.0;
        }
        private double _top;
        // The number of beats per bar (e.g. the 6 in 6/8).
        public double Top
        {
            get
            {
                return _top;
            }
            set
            {
                if (value == _top)
                    return;
                _top = value;
                RaisePropertyChanged("Top");
                TopHasChanged();
            }
        }
        // The size of the beats (e.g. the 8 in 6/8)/ 
        private double _bottom;
        public double Bottom
        {
            get
            {
                return _bottom;
            }
            set
            {
                if (value == _bottom)
                    return;
                _bottom = value;
                BottomHasChanged();
                RaisePropertyChanged("Bottom");
            }
        }
        // The tempo, beats per minute.
        private double _tempo;
        public double Tempo
        {
            get
            {
                return Math.Round(_tempo);
            }
            set
            {
                if (value == _tempo)
                    return;
                _tempo = value;
                RaisePropertyChanged("Tempo");
            }
        }
        // The current song position, in quarter notes with the fractional part indicating the progress to the next note.
        private double _current;
        public double Current
        {
            get { return Math.Floor(_current); }
            set
            {
                if (value == _current)
                    return;
                _current = value;
                RaisePropertyChanged("Current", "Position");
            }
        }

        public int Flash { get { return Beat == _top ? 3 : 0; } }
        private double _beat;
        // The current beat position in the current bar (starts with 1).
        public double Beat
        {
            get { return _beat; }
            set
            {
                if (value == _beat)
                    return;
                _beat = value;
                RaisePropertyChanged("Beat", "Position", "Flash");
            }
        }
        public string Position { get { return String.Format("{0}.{1}", CurrentBar, Beat); } }

        private int _percent;
        // an integer 0 to 99 indicating the percentage complete.
        public int Percent
        {
            get { return _percent; }
            set
            {
                if (value == _percent)
                    return;
                _percent = value;
                RaisePropertyChanged("Percent");
            }
        }
        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                if (value == _message)
                    return;
                _message = value;
                RaisePropertyChanged("Message");
            }
        }
        // Ticks are (arbitrarily) 16th notes.
        //private double _lastTicks = 0;

        // This counts the bars.  Note that the bars can be different sizes because the time signature can change.
        private int _currentBar = 0;
        public int CurrentBar
        {
            get { return _currentBar; }
            set
            {
                if (value == _currentBar)
                    return;
                _currentBar = value;
                RaisePropertyChanged("CurrentBar");
            }
        }

        // the ratio of a full cycle.
        private double _phase;
        //private double _newTop, _newBottom;

        private double _lastBarStartTicks;


        public void ProcessIdle(double top, double bottom, double tempo, double current, double barStart, double cycleStart, double cycleEnd)
        {
            /* new approach. 
             * The BarStart tells us where the bar started (actually a fraction of a second before), an dCurrent tells us the cuurent location.
             * Combined with the top and bottom, that's all we need to know!
             * */
            Top = top;
            Bottom = bottom;
            Tempo = tempo;
            /* Cycle start and end refer to the loop positions. */

            //Issues right now: 
            // // not resetting when rewinding
            // // is counting bars correctly!

            //!  NEED TO:
            // Detect when at start of project....
            // Build an list of bar start positions
            // Use this to track from the current anywhere, any time.
            Current = Math.Floor(current);
            if (Math.Floor(current) == 0)
                CurrentBar = 0;

            // Convert to ticks (1/16th notes)
            double currentTicks = current * 4.0;
            double barStartTicks = Math.Round(barStart * 4.0);
            if (_lastBarStartTicks != barStartTicks)
            {
                // we have just moved to the next bar!
                CurrentBar++;
                _lastBarStartTicks = barStartTicks;
            }
            double ticksPerBar = 16 * top / bottom;
            double ticksPerBeat = ticksPerBar / top;
            double barTickPosition = currentTicks - barStartTicks;
            _phase = barTickPosition / ticksPerBar;
            Beat = Math.Floor(barTickPosition / ticksPerBeat + 1);
            IndicateProgress();
            //Message = String.Format("Bar: {0} _phase: {1:0.000} Beat: {2}", CurrentBar, _phase, Beat);
            Message = String.Format("{0}", _current);
            RaisePropertyChanged("Position");
        }

        private Point[] _points;
        private void TopHasChanged()
        {
            switch ((int)_top % 8)
            {
                case 2:
                    _points = new Point[]
                    {
                        new Point(_scale, 2*_scale),
                        new Point(_scale, 0)
                    };
                    break;
                case 3:
                    _points = new Point[]
                    {
                        new Point(_scale, 2*_scale), 
                        new Point(0, 1.2*_scale),                
                        new Point(_scale, 0)
                    };
                    break;
                case 4:
                    _points = new Point[]
                    {
                        new Point(_scale, 2*_scale), 
                        new Point(0, 1.2*_scale), 
                        new Point(2*_scale, 1.2*_scale), 
                        new Point(_scale, 0)
                    };
                    break;
                case 5:
                    _points = new Point[]
                    {
                        new Point(_scale, 2*_scale), 
                        new Point(0, 1.2*_scale), 
                        new Point(2*_scale, 1.2*_scale), 
                        new Point(0, 0.8*_scale),             
                        new Point(_scale, 0)
                    };
                    break;
                case 6:
                    _points = new Point[]
                    {
                        new Point(_scale, 2*_scale), 
                        new Point(0, 1.2*_scale), 
                        new Point(2*_scale, 1.2*_scale), 
                        new Point(0, 0.8*_scale),
                        new Point(2* _scale, 0.80*_scale),
                        new Point(_scale, 0)
                    };
                    break;
                case 7:
                    _points = new Point[]
                    {
                        new Point(_scale, 2*_scale), 
                        new Point(0, 1.2*_scale), 
                        new Point(2*_scale, 1.2*_scale), 
                        new Point(0, 0.8*_scale),
                        new Point(2* _scale, 0.80*_scale),
                        new Point(0, 1.20*_scale),
                        new Point(_scale, 0)
                    };
                    break;
                case 8:
                default:
                    _points = new Point[]
                    {
                        new Point(_scale, 2*_scale), 
                        new Point(0, 1.2*_scale), 
                        new Point(2*_scale, 1.2*_scale), 
                        new Point(0, 0.8*_scale),
                        new Point(2* _scale, 0.80*_scale),
                        new Point(0, 1.20*_scale), 
                        new Point(2*_scale, 1.20*_scale ),    
                        new Point(_scale, 0)
                    };
                    break;
            }
        }

        public double Heat
        {
            get { return Beat == _top ? 1.0 : 1.0 - _ratio * 0.7; }
        }
        // display unit scaling
        private double _scale;

        // return a point proportionally located between two points.
        private Point Interpolate(Point from, Point to, double ratio)
        {
            double x = to.X * ratio + from.X * (1 - ratio);
            double y = to.Y * ratio + from.Y * (1 - ratio);
            return new Point(x, y);
        }
        // Approximates a spline with a cebtral control point.
        private Point CenterInterpolate(Point from, Point to, Point center, double ratio)
        {
            Point a = Interpolate(from, center, ratio);
            Point b = Interpolate(center, to, ratio);
            return Interpolate(a, b, ratio);
        }

        private double _ratio;
        private double _factor;
        private void BottomHasChanged()
        {
            _factor = Bottom / 4;
        }
        private void IndicateProgress()
        {
            if (_top == 0) return;
            _ratio = _phase * _top;
            _ratio = _ratio - Math.Floor(_ratio);

            int from = (int)Beat - 1;
            int to = (int)Beat % (int)(_top); // to accommodate silly large bar sizes
            if (from < 0 || from >= (int)_top) return;
            if (to < 0 || to >= (int)_top) return;
            Point m = CenterInterpolate(_points[from], _points[to], new Point(_scale, _scale), _ratio);
            X = m.X;
            Y = m.Y;
            RaisePropertyChanged("Heat", "X", "Y");
            Message = String.Format("{0}-{1}", X, Y);
        }

        public double X { get; set; }
        public double Y { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(params string[] propertyNames)
        {
            if (PropertyChanged != null)
                foreach (string propertyName in propertyNames)
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


