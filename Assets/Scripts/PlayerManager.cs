﻿using UnityEngine;
using Normal.Realtime;

namespace Normal.Realtime.Examples
{
    public class PlayerManager : MonoBehaviour
    {
        private Realtime _realtime;

        private void Awake()
        {
            // Get the Realtime component on this game object
            _realtime = GetComponent<Realtime>();

            // Notify us when Realtime successfully connects to the room
            _realtime.didConnectToRoom += DidConnectToRoom;
        }

        private void DidConnectToRoom(Realtime realtime)
        {
            var playerPrefs = FindObjectOfType<PlayerPreferences>();
            var playerTypeToLoad = "Player";

            if (playerPrefs != null)
            {
                switch (playerPrefs.Customization)
                {
                    case Customizations.BunnyEars:
                        playerTypeToLoad = "PlayerWithEars";
                        break;
                    case Customizations.None:
                    default:
                        break;
                }
            }

            // Instantiate the CubePlayer for this client once we've successfully connected to the room
            Realtime.Instantiate(playerTypeToLoad,                     // Prefab name
                                position: Vector3.up,          // Start 1 meter in the air
                                rotation: Quaternion.identity, // No rotation
                           ownedByClient: true,                // Make sure the RealtimeView on this prefab is owned by this client
                preventOwnershipTakeover: true,                // Prevent other clients from calling RequestOwnership() on the root RealtimeView.
                             useInstance: realtime);           // Use the instance of Realtime that fired the didConnectToRoom event.
        }
    }
}
