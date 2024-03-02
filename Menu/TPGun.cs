using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;
using GorillaLocomotion.Gameplay;

namespace SmittyModMenu.Menu
{
    internal class TPGun
{
        public static GameObject pointer;
        public static void TPGunMod()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out var hitinfo);
                pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                pointer.transform.position = hitinfo.point;
                pointer.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                pointer.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
                pointer.GetComponent<Renderer>().material.color = new Color32(0, 0, 128, 1);
                GameObject.Destroy(pointer.GetComponent<BoxCollider>());
                GameObject.Destroy(pointer.GetComponent<Rigidbody>());
                GameObject.Destroy(pointer.GetComponent<Collider>());
                if (ControllerInputPoller.instance.rightControllerIndexFloat >= 0.1)
                {
                    GameObject.Destroy(pointer, Time.deltaTime);
                    pointer.GetComponent<Renderer>().material.color = new Color32(0, 255, 255, 1);
                    GorillaTagger.Instance.offlineVRRig.transform.position = hitinfo.point;


                }

            }
            if (pointer != null)
            {
                GameObject.Destroy(pointer, Time.deltaTime);
            }
        }
    }
}
