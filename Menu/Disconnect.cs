using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;

namespace SmittyModMenu.Menu
{
    internal class Disconnect
{
    public static void DisconnectMod()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                PhotonNetwork.Disconnect();
            }
        }
}
}
