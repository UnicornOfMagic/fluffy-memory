using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    CinemachineVirtualCamera cineCam;

    [SerializeField]
    private GameObject playerLocater = null;
    void Start()
    {
        cineCam = GetComponent<CinemachineVirtualCamera>();
    }

    void Update()
    {
        var player = playerLocater.GetComponent<LocalPlayerLocater>();
        if (cineCam.Follow == null)
            TryToFollowLocalPlayer();
    }

    void TryToFollowLocalPlayer()
    {
        var localPLayer = playerLocater.GetComponent<LocalPlayerLocater>().localPlayer;
        if (localPLayer != null)
            cineCam.Follow = localPLayer.transform;
    }
}
