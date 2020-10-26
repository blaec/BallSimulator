using System;
using System.Collections.Generic;
using System.Text;

namespace BallSimulator
{
    class Ball
    {
        public event EventHandler<BallEventArgs> BallInPlay;
        protected void OnBallInPlay(BallEventArgs e)
        {
            BallInPlay?.Invoke(this, e);
        }
        public Bat GetNewBat()
        {
            return new Bat(new BatCallback(OnBallInPlay));
        }
    }
}
