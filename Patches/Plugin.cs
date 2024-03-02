using BepInEx;
using System.ComponentModel;

namespace SmittyModMenu.Patches
{
    [Description(SmittyModMenu.PluginInfo.Description)]
    [BepInPlugin(SmittyModMenu.PluginInfo.GUID, SmittyModMenu.PluginInfo.Name, SmittyModMenu.PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        private void OnEnable()
        {
            Menu.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            Menu.RemoveHarmonyPatches();
        }
    }
}
