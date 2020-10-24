using System;
using System.Collections.Generic;
using System.Text;

namespace BallSimulator
{
    class Ball
    {
        public event EventHandler BallInPlay;
        public void OnBallInPlay(BallEventArgs e)
        {
            EventHandler ballInPlay = BallInPlay;
            if (ballInPlay != null)
                ballInPlay(this, e);
        }
    }
}
