
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.XR;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;
using BepInEx;
using ExitGames.Client.Photon;
using GorillaNetworking;
using HarmonyLib;
using static SmittyModMenu.Menu.LongArms;
using Photon.Pun;
using Photon.Realtime;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine.InputSystem;
using UnityEngine.UI;




namespace SmittyModMenu.Menu
{
    internal class Platforms
    {
        public static int platformMode = 0;
        public static int platformShape = 0;
        public static GameObject leftplat = null;
        public static GameObject rightplat = null;
        public static int themeType = 1;
        public static Color bgColorA = new Color32(255, 128, 0, 128);
        public static Color bgColorB = new Color32(255, 102, 0, 128);
        public static Material glass = null;
        public static float armlength = 1.25f;
        public static void PlatformsMod()
        {
            if (ControllerInputPoller.instance.leftGrab)
            {
                if (leftplat == null)
                {
                    if (platformShape == 0)
                    {
                        leftplat = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        leftplat.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
                    }
                    if (platformShape == 1)
                    {
                        leftplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        leftplat.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
                    }
                    if (platformShape == 2)
                    {
                        leftplat = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                        leftplat.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
                    }
                    if (platformShape == 3)
                    {
                        leftplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        leftplat.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                    }
                    if (platformShape == 4)
                    {
                        leftplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        leftplat.transform.localScale = new Vector3(0.025f, 0.15f, 0.2f);
                    }
                    if (platformShape == 5)
                    {
                        leftplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        leftplat.transform.localScale = new Vector3(0.025f, 0.3f, 0.8f);
                    }
                    if (platformShape == 6)
                    {
                        leftplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        leftplat.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    }
                    leftplat.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    leftplat.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
                    if (platformMode != 5)
                    {
                        GradientColorKey[] array = new GradientColorKey[3];
                        array[0].color = bgColorA;
                        array[0].time = 0f;
                        array[1].color = bgColorB;
                        array[1].time = 0.5f;
                        array[2].color = bgColorA;
                        array[2].time = 1f;

                        Gradient bg = new Gradient
                        {
                            colorKeys = array
                        };

                        if (themeType == 6)
                        {
                            float h = (Time.frameCount / 180f) % 1f;
                            leftplat.GetComponent<Renderer>().material.color = UnityEngine.Color.HSVToRGB(h, 1f, 1f);
                        }
                        else
                        {
                            leftplat.GetComponent<Renderer>().material.color = bg.Evaluate((Time.time / 2f) % 1);
                        }
                    }
                    if (longarmsactive == 1)
                    {
                        leftplat.transform.position = GorillaTagger.Instance.leftHandTransform.position + GorillaTagger.Instance.leftHandTransform.forward * (armlength - 0.917f);
                    }
                    if (platformMode == 1)
                    {
                        leftplat.GetComponent<Renderer>().enabled = false;
                    }
                    if (platformMode == 2)
                    {
                        float h = (Time.frameCount / 180f) % 1f;
                        leftplat.GetComponent<Renderer>().material.color = UnityEngine.Color.HSVToRGB(h, 1f, 1f);
                    }
                    if (platformMode == 3)
                    {
                        leftplat.GetComponent<Renderer>().material.color = new Color32((byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), 128);
                    }
                    if (platformMode == 4)
                    {
                        foreach (MeshCollider v in Resources.FindObjectsOfTypeAll<MeshCollider>())
                        {
                            v.enabled = false;
                        }
                    }
                    if (platformMode == 5)
                    {
                        leftplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 29;
                        if (glass == null)
                        {
                            glass = new Material(Shader.Find("GUI/Text Shader"));
                            glass.SetFloat("_Mode", 3f);
                            glass.color = new Color32(145, 187, 255, 100);
                        }
                        leftplat.GetComponent<Renderer>().material = glass;
                    }
                    if (platformMode == 6)
                    {
                        leftplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 32;
                        leftplat.GetComponent<Renderer>().enabled = false;
                    }
                    if (platformMode == 7)
                    {
                        leftplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 204;
                        leftplat.GetComponent<Renderer>().enabled = false;
                    }
                    if (platformMode == 8)
                    {
                        leftplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 231;
                        leftplat.GetComponent<Renderer>().enabled = false;
                    }
                    if (platformMode == 9)
                    {
                        leftplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 240;
                        leftplat.GetComponent<Renderer>().enabled = false;
                    }
                    if (platformMode == 10)
                    {
                        leftplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 249;
                        leftplat.GetComponent<Renderer>().enabled = false;
                    }
                }
                else
                {
                    if (platformMode != 5)
                    {
                        GradientColorKey[] array = new GradientColorKey[3];
                        array[0].color = bgColorA;
                        array[0].time = 0f;
                        array[1].color = bgColorB;
                        array[1].time = 0.5f;
                        array[2].color = bgColorA;
                        array[2].time = 1f;

                        Gradient bg = new Gradient
                        {
                            colorKeys = array
                        };

                        if (themeType == 6)
                        {
                            float h = (Time.frameCount / 180f) % 1f;
                            leftplat.GetComponent<Renderer>().material.color = UnityEngine.Color.HSVToRGB(h, 1f, 1f);
                        }
                        else
                        {
                            leftplat.GetComponent<Renderer>().material.color = bg.Evaluate((Time.time / 2f) % 1);
                        }
                    }
                    if (platformMode == 2)
                    {
                        float h = (Time.frameCount / 180f) % 1f;
                        leftplat.GetComponent<Renderer>().material.color = UnityEngine.Color.HSVToRGB(h, 1f, 1f);
                    }
                    if (platformMode == 3)
                    {
                        leftplat.GetComponent<Renderer>().material.color = new Color32((byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), 128);
                    }
                }
            }
            else
            {
                if (leftplat != null)
                {
                    UnityEngine.GameObject.Destroy(leftplat);
                    leftplat = null;
                    if (platformMode == 4 && rightplat == null)
                    {
                        foreach (MeshCollider v in Resources.FindObjectsOfTypeAll<MeshCollider>())
                        {
                            v.enabled = true;
                        }
                    }
                }
            }

            if (ControllerInputPoller.instance.rightGrab)
            {
                if (rightplat == null)
                {
                    if (platformShape == 0)
                    {
                        rightplat = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        rightplat.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
                    }
                    if (platformShape == 1)
                    {
                        rightplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        rightplat.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
                    }
                    if (platformShape == 2)
                    {
                        rightplat = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                        rightplat.transform.localScale = new Vector3(0.333f, 0.333f, 0.333f);
                    }
                    if (platformShape == 3)
                    {
                        rightplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        rightplat.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                    }
                    if (platformShape == 4)
                    {
                        rightplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        rightplat.transform.localScale = new Vector3(0.025f, 0.15f, 0.2f);
                    }
                    if (platformShape == 5)
                    {
                        rightplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        rightplat.transform.localScale = new Vector3(0.025f, 0.3f, 0.8f);
                    }
                    if (platformShape == 6)
                    {
                        rightplat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        rightplat.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    }
                    rightplat.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    rightplat.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                    if (platformMode != 5)
                    {
                        GradientColorKey[] array = new GradientColorKey[3];
                        array[0].color = bgColorA;
                        array[0].time = 0f;
                        array[1].color = bgColorB;
                        array[1].time = 0.5f;
                        array[2].color = bgColorA;
                        array[2].time = 1f;

                        Gradient bg = new Gradient
                        {
                            colorKeys = array
                        };

                        if (themeType == 6)
                        {
                            float h = (Time.frameCount / 180f) % 1f;
                            rightplat.GetComponent<Renderer>().material.color = UnityEngine.Color.HSVToRGB(h, 1f, 1f);
                        }
                        else
                        {
                            rightplat.GetComponent<Renderer>().material.color = bg.Evaluate((Time.time / 2f) % 1);
                        }
                    }
                    if (longarmsactive == 1 )
                    {
                        rightplat.transform.position = GorillaTagger.Instance.rightHandTransform.position + GorillaTagger.Instance.rightHandTransform.forward * (armlength - 0.917f);
                    }
                    if (platformMode == 1)
                    {
                        rightplat.GetComponent<Renderer>().enabled = false;
                    }
                    if (platformMode == 2)
                    {
                        float h = (Time.frameCount / 180f) % 1f;
                        rightplat.GetComponent<Renderer>().material.color = UnityEngine.Color.HSVToRGB(h, 1f, 1f);
                    }
                    if (platformMode == 3)
                    {
                        rightplat.GetComponent<Renderer>().material.color = new Color32((byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), 128);
                    }
                    if (platformMode == 4)
                    {
                        foreach (MeshCollider v in Resources.FindObjectsOfTypeAll<MeshCollider>())
                        {
                            v.enabled = false;
                        }
                    }
                    if (platformMode == 5)
                    {
                        rightplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 29;
                        if (glass == null)
                        {
                            glass = new Material(Shader.Find("GUI/Text Shader"));
                            glass.SetFloat("_Mode", 3f);
                            glass.color = new Color32(145, 187, 255, 100);
                        }
                        rightplat.GetComponent<Renderer>().material = glass;
                    }
                    if (platformMode == 6)
                    {
                        rightplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 32;
                        rightplat.GetComponent<Renderer>().enabled = false;
                    }
                    if (platformMode == 7)
                    {
                        rightplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 204;
                        rightplat.GetComponent<Renderer>().enabled = false;
                    }
                    if (platformMode == 8)
                    {
                        rightplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 231;
                        rightplat.GetComponent<Renderer>().enabled = false;
                    }
                    if (platformMode == 9)
                    {
                        rightplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 240;
                        rightplat.GetComponent<Renderer>().enabled = false;
                    }
                    if (platformMode == 10)
                    {
                        rightplat.AddComponent<GorillaSurfaceOverride>().overrideIndex = 249;
                        rightplat.GetComponent<Renderer>().enabled = false;
                    }
                }
                else
                {
                    if (platformMode != 5)
                    {
                        GradientColorKey[] array = new GradientColorKey[3];
                        array[0].color = bgColorA;
                        array[0].time = 0f;
                        array[1].color = bgColorB;
                        array[1].time = 0.5f;
                        array[2].color = bgColorA;
                        array[2].time = 1f;

                        Gradient bg = new Gradient
                        {
                            colorKeys = array
                        };

                        if (themeType == 6)
                        {
                            float h = (Time.frameCount / 180f) % 1f;
                            rightplat.GetComponent<Renderer>().material.color = UnityEngine.Color.HSVToRGB(h, 1f, 1f);
                        }
                        else
                        {
                            rightplat.GetComponent<Renderer>().material.color = bg.Evaluate((Time.time / 2f) % 1);
                        }
                    }
                    if (platformMode == 2)
                    {
                        float h = (Time.frameCount / 180f) % 1f;
                        rightplat.GetComponent<Renderer>().material.color = UnityEngine.Color.HSVToRGB(h, 1f, 1f);
                    }
                    if (platformMode == 3)
                    {
                        rightplat.GetComponent<Renderer>().material.color = new Color32((byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), (byte)UnityEngine.Random.Range(0, 255), 128);
                    }
                }
            }
            else
            {
                if (rightplat != null)
                {
                    UnityEngine.GameObject.Destroy(rightplat);
                    rightplat = null;
                    if (platformMode == 4 && leftplat == null)
                    {
                        foreach (MeshCollider v in Resources.FindObjectsOfTypeAll<MeshCollider>())
                        {
                            v.enabled = true;
                        }
                    }
                }
            }
        }

    }
} 
        
    


