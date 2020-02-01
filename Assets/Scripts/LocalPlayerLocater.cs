using Normal.Realtime;
using UnityEngine;

public class LocalPlayerLocater : MonoBehaviour
{
    [SerializeField]
    public GameObject localPlayer = null;

    [SerializeField]
    public GameObject startMessage;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(localPlayer == null)
        {
            FindLocalPlayer();
        }
    }

    void FindLocalPlayer()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject player in players)
        {
            if (player.GetComponent<RealtimeView>().isOwnedLocally)
            {
                localPlayer = player;
                Destroy(startMessage);
            }

        }
    }
}
