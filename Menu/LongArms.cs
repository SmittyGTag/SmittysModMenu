using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SmittyModMenu.Menu
{
    internal class LongArms
{
        public static int longarmsactive = 0;
        public static void LongArmsMod()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            longarmsactive = 1;
        }
        public static void DisableLongArms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
            longarmsactive = 0;
        }

    }
}
