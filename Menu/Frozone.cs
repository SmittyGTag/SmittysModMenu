using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


namespace SmittyModMenu.Menu
{
    internal class Frozone
{
        public static void FrozoneMod()
        {
            if (ControllerInputPoller.instance.leftGrab)
            {
                GameObject lol = GameObject.CreatePrimitive(PrimitiveType.Cube);
                lol.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                lol.transform.localPosition = GorillaTagger.Instance.leftHandTransform.position + new Vector3(0f, -0.05f, 0f);
                lol.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;

                lol.AddComponent<GorillaSurfaceOverride>().overrideIndex = 61;
                UnityEngine.Object.Destroy(lol, 1);
            }

            if (ControllerInputPoller.instance.rightGrab)
            {
                GameObject lol = GameObject.CreatePrimitive(PrimitiveType.Cube);
                lol.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                lol.transform.localPosition = GorillaTagger.Instance.rightHandTransform.position + new Vector3(0f, -0.05f, 0f);
                lol.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;

                lol.AddComponent<GorillaSurfaceOverride>().overrideIndex = 61;
                UnityEngine.Object.Destroy(lol, 1);
            }
        }

    }
}
