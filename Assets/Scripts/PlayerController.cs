using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float speed = 5.0f;

    private RealtimeView _realtimeView;
    private RealtimeTransform _realtimeTransform;

    private void Awake()
    {
        _realtimeView = GetComponent<RealtimeView>();
        _realtimeTransform = GetComponent<RealtimeTransform>();
    }

    private void FixedUpdate()
    {
        // If this CubePlayer prefab is not owned by this client, bail.
        if (!_realtimeView.isOwnedLocally)
            return;

        // Make sure we own the transform so that RealtimeTransform knows to use this client's transform to synchronize remote clients.
        _realtimeTransform.RequestOwnership();

        // Grab the x/y input from WASD / a controller
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Apply to the transform
        Vector3 localPosition = transform.localPosition;
        localPosition.x += x * speed * Time.deltaTime * 3;
        localPosition.z += z * speed * Time.deltaTime * 3;
        transform.localPosition = localPosition;
    }


}

