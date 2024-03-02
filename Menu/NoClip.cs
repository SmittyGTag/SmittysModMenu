using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SmittyModMenu.Menu
{
    internal class NoClip
    {
        public static void NoClipMod()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                foreach (MeshCollider v in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    v.enabled = false;
                }
            }
            else
            {
                foreach (MeshCollider v in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    v.enabled = true;
                }


            }
            
        }
    }
}