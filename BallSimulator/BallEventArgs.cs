using System;
using System.Collections.Generic;
using System.Text;

namespace BallSimulator
{
    class BallEventArgs : EventArgs
    {
        public int Trajectory { get; private set; }
        public int Distance { get; private set; }
        public BallEventArgs(int trajectory, int distance)
        {
            this.Trajectory = trajectory;
            this.Distance = distance;
        }
    }
}
