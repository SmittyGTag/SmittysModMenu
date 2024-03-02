using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using GorillaLocomotion;
using UnityEngine;
using GorillaLocomotion.Gameplay;

namespace SmittyModMenu.Menu
{
    internal class RopeGun
    {
            public static GameObject pointer;

            public static void RopeGunMod()
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    if (Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position - GorillaLocomotion.Player.Instance.rightControllerTransform.up, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out RaycastHit raycastHit) && pointer == null)
                    {
                        pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        UnityEngine.Object.Destroy(pointer.GetComponent<Rigidbody>());
                        UnityEngine.Object.Destroy(pointer.GetComponent<SphereCollider>());
                        pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                        pointer.GetComponent<Renderer>().material.color = Color.white;
                    }
                    pointer.transform.position = raycastHit.point;
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
                    {
                            foreach (GorillaRopeSwing rope in GameObject.FindObjectsOfType(typeof(GorillaRopeSwing)))
                            {
                                RopeSwingManager.instance.SendSetVelocity_RPC(rope.ropeId, 1, new UnityEngine.Vector3(float.MaxValue, float.MaxValue, float.MaxValue), true);
                            }
                        }
                    }
                    else
                    {
                        UnityEngine.GameObject.Destroy(pointer);
                    }
                }
            }
        }

