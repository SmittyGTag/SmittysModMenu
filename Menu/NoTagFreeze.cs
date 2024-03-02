using System;
using System.Collections.Generic;
using System.Text;

namespace SmittyModMenu.Menu
{
    internal class NoTagFreeze
    {
        public static void NoTagFreezeMod()
        {
            GorillaLocomotion.Player.Instance.disableMovement = false;
        }
    }
}
