using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

namespace Rivviann
{
    public class TitleScreenManager : MonoBehaviour
    {
        public void StartNetworkAsHost() 
        {
            NetworkManager.Singleton.StartHost();
        } 
    }
}
