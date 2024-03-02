using SmittyModMenu.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.XR;
using Valve.VR;

namespace SmittyModMenu.Menu
{
    internal class Fly

    { 
        public static void FlyMod()
        {

            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 2.4f;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero; // makes it to where your rig won't fall while flying.
            }
        }


    }

}

