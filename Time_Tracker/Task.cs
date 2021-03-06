using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Time_Tracker
{
    public class Task
    {

        public Task Parent { get; set; }

        private TimeSpan _totalTime;
        private readonly Stopwatch _timer;
        private List<Task> _children;

        public TimeSpan GetTime()
        {
            TimeSpan elapsedTime = new TimeSpan();

            if (_timer.IsRunning)
            {
                elapsedTime = _totalTime + _timer.Elapsed;
            }
            else
            {
                elapsedTime = _totalTime;
            }

            return elapsedTime;
        }

        public void StartTimer()
        {
            _timer.Start();
        }

        public void StopTimer()
        {
            _timer.Stop();
            _totalTime += _timer.Elapsed;
        }

        public int NumChildren()
        {
            return _children.Count;
        }

        public void AddChild()
        {
            _children.Add(new Task(this));
        }

        public Task(Task parent = null)
        {
            Parent = parent;
            _totalTime = new TimeSpan();
            _timer = new Stopwatch();
            _children = new List<Task>(0);
        }



    }
}
