using System;
using System.Collections.Generic;
using System.Text;

namespace SmittyModMenu.Menu
{
    internal class SpeedBoost
{
        public static void SpeedboostMod()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 9;
        }
    }
}
