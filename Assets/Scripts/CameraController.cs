using Cinemachine;
using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    CinemachineVirtualCamera cineCam;
    // Start is called before the first frame update
    void Start()
    {

        cineCam = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!player)
            FindPlayer();
        
    }

    private void FindPlayer()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");
        foreach(GameObject player in players)
        {
            if (player.GetComponent<RealtimeView>().isOwnedLocally)
            {
                this.player = player;
                cineCam.Follow = this.player.transform;
            }
        }
    }
}
