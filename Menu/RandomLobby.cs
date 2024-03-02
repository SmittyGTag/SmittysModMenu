using System;
using System.Collections.Generic;
using System.Text;
using Photon.Pun;
namespace SmittyModMenu.Menu
{
    internal class RandomLobby
{
        public static void RandomLobbyMod()
        {
            if (ControllerInputPoller.instance.leftGrab)
            {
                PhotonNetwork.JoinRandomRoom();
            }
        }
}
}
