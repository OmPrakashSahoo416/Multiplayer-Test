using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;

    [SerializeField] float minX;
    [SerializeField] float minY;
    [SerializeField] float maxX;
    [SerializeField] float maxY;

    private void Start()
    {
        Vector2 randomPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPos, Quaternion.identity);
    }
}
