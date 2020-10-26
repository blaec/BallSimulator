using System;
using System.Collections.Generic;
using System.Text;

namespace BallSimulator
{
    class Bat
    {
        private BatCallback hitBallCallback;
        public Bat(BatCallback callbackDelegate)
        {
            this.hitBallCallback = new BatCallback(callbackDelegate);
        }
        public void HitTheBall(BallEventArgs e)
        {
            hitBallCallback?.Invoke(e);
        }
    }
}
