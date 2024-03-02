using SmittyModMenu.Classes;
using SmittyModMenu.Mods;
using static SmittyModMenu.Settings;

namespace SmittyModMenu.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Join Random Lobby", method =() => RandomLobby.RandomLobbyMod(), toolTip = "Joins Random Lobby using left grip"},
                new ButtonInfo { buttonText = "Speed Boost", method =() => SpeedBoost.SpeedboostMod(), toolTip = "Slight speed boost"},
                new ButtonInfo { buttonText = "Steam Long Arms", enableMethod =() => LongArms.LongArmsMod(), disableMethod =() => LongArms.DisableLongArms(), toolTip = "Gives you long arms similar to override world scale."},
                new ButtonInfo { buttonText = "No Clip", method =() => NoClip.NoClipMod(), toolTip = "Allows to go through walls threw the map"},
                new ButtonInfo { buttonText = "Water Splash Hands", method =() => WaterHands.WaterSplashHands(), toolTip = "Water on hands, use grips"},
                new ButtonInfo { buttonText = "Solid Water (Beach)", method =() => WaterHands.SolidWater(), toolTip = "Turns water to a solid"},
                new ButtonInfo { buttonText = "No Water (Beach)", method =() => WaterHands.DisableWater(), toolTip = "Makes the water go bye bye"},
                new ButtonInfo { buttonText = "Fix Water (Beach)", method =() => WaterHands.FixWater(), toolTip = "Puts water back in beach map"},
                new ButtonInfo { buttonText = "Platforms", method =() => Platforms.PlatformsMod(), toolTip = "Hold the grips and walk around"},
                new ButtonInfo { buttonText = "Frozone", method =() => Frozone.FrozoneMod(), toolTip = "Moves likes frozone around the map"},
                new ButtonInfo { buttonText = "Fly", method =() => Fly.FlyMod(), toolTip = "You can fly around the map"},
                new ButtonInfo { buttonText = "Teleport Gun", method =() => TPGun.TPGunMod(), toolTip = "Grab grips to point, pull trigger to teleport"},
                new ButtonInfo { buttonText = "No Tag Freeze", method =() => NoTagFreeze.NoTagFreezeMod(), toolTip = "Allows you to move when tagged, new round, etc."},
                new ButtonInfo { buttonText = "Ropes Control", method =() => RopesControl.RopeControlMod(), toolTip = "Allows all desert + beach ropes to move using joystick"},
                new ButtonInfo { buttonText = "Grip Rope Control", method =() => RopeGun.RopeGunMod(), toolTip = "Allows you to control ropes with right grips"},
                new ButtonInfo { buttonText = "Finger Painter", enableMethod =() => FingerPainter.FingerPainterMod(), disableMethod =() => FingerPainter.FingerPainterModOff(), toolTip = "Gives you fingerpainter"},



            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
