using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks
{ 
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }


}
