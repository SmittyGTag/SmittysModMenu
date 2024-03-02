using System;
using System.Collections.Generic;
using System.Text;

namespace SmittyModMenu.Menu
{
    internal class FingerPainter
{
       public static void FingerPainterMod()
        {
            UnityEngine.GameObject.Find("Player Objects/LocalVRRig/Local Gorilla Player/rig/body/2023_04DungeonV2 Body/LBade.").SetActive(true);
        }
        public static void FingerPainterModOff()
        {
            UnityEngine.GameObject.Find("Player Objects/LocalVRRig/Local Gorilla Player/rig/body/2023_04DungeonV2 Body/LBade.").SetActive(false);
        }
    }
}
