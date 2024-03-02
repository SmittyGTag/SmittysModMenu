using UnityEngine;
using static SmittyModMenu.Menu.Main;
using static UnityEngine.Object;
using SmittyModMenu.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
using ExitGames.Client.Photon;
using Photon.Realtime;


namespace SmittyModMenu.Menu
{

    internal class WaterHands
    {
        public static float splashDel = 0f;
        public static bool hasRemovedThisFrame = false;
        public static void RPCProtection()
        {
            if (hasRemovedThisFrame == false)
            {
                hasRemovedThisFrame = true;
                if (GetIndex("Experimental RPC Protection").enabled)
                {
                    RaiseEventOptions options = new RaiseEventOptions();
                    options.CachingOption = EventCaching.RemoveFromRoomCache;
                    options.TargetActors = new int[1] { PhotonNetwork.LocalPlayer.ActorNumber };
                    RaiseEventOptions optionsdos = options;
                    PhotonNetwork.NetworkingClient.OpRaiseEvent(200, null, optionsdos, SendOptions.SendReliable);
                }
                else
                {
                    GorillaNot.instance.rpcErrorMax = int.MaxValue;
                    GorillaNot.instance.rpcCallLimit = int.MaxValue;
                    GorillaNot.instance.logErrorMax = int.MaxValue;
                    // GorillaGameManager.instance.maxProjectilesToKeepTrackOfPerPlayer = int.MaxValue;

                    PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
                    PhotonNetwork.OpCleanRpcBuffer(GorillaTagger.Instance.myVRRig);
                    PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
                    PhotonNetwork.RemoveRPCsInGroup(int.MaxValue);
                    PhotonNetwork.SendAllOutgoingCommands();
                    GorillaNot.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);
                }
            }
        }
        public static void DisableWater()
        {
            GameObject water = GameObject.Find("Environment Objects/LocalObjects_Prefab/Beach/B_WaterVolumes");
            Transform waterTransform = water.transform;
            for (int i = 0; i < waterTransform.childCount; i++)
            {
                GameObject v = waterTransform.GetChild(i).gameObject;
                v.layer = LayerMask.NameToLayer("TransparentFX");
            }
        }

        public static void SolidWater()
        {
            GameObject water = GameObject.Find("Environment Objects/LocalObjects_Prefab/Beach/B_WaterVolumes");
            Transform waterTransform = water.transform;
            for (int i = 0; i < waterTransform.childCount; i++)
            {
                GameObject v = waterTransform.GetChild(i).gameObject;
                v.layer = LayerMask.NameToLayer("Default");
            }
        }

        public static void FixWater()
        {
            GameObject water = GameObject.Find("Environment Objects/LocalObjects_Prefab/Beach/B_WaterVolumes");
            Transform waterTransform = water.transform;
            for (int i = 0; i < waterTransform.childCount; i++)
            {
                GameObject v = waterTransform.GetChild(i).gameObject;
                v.layer = LayerMask.NameToLayer("Water");
            }
        }

        public static void WaterSplashHands()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (Time.time > splashDel)
                {
                    GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", RpcTarget.All, new object[]
                    {
                        GorillaTagger.Instance.rightHandTransform.position,
                        GorillaTagger.Instance.rightHandTransform.rotation,
                        4f,
                        100f,
                        true,
                        false
                    });
                    RPCProtection();
                    splashDel = Time.time + 0.1f;
                }
            }
            if (ControllerInputPoller.instance.leftGrab)
            {
                if (Time.time > splashDel)
                {
                    GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", RpcTarget.All, new object[]
                    {
                        GorillaTagger.Instance.leftHandTransform.position,
                        GorillaTagger.Instance.leftHandTransform.rotation,
                        4f,
                        100f,
                        true,
                        false
                    });
                    RPCProtection();
                    splashDel = Time.time + 0.1f;
                }
            }

        }
    }
}
