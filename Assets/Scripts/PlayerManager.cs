using UnityEngine;
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
            _realtime.didConnectToRoom += CreateBall;
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

            InstantiateNewObjectInWorld(playerTypeToLoad, realtime);
        }

        private void CreateBall(Realtime realtime)
        {
            InstantiateNewObjectInWorld("Sphere", realtime);
        }

        private void InstantiateNewObjectInWorld(string prefab, Realtime realtime)
        {
            Vector3 startingPosition = new Vector3(Random.Range(-4, 4),1, Random.Range(-4, 4 ));
            Realtime.Instantiate(prefab,                     // Prefab name
                                position: startingPosition,          // Start 1 meter in the air
                                rotation: Quaternion.identity, // No rotation
                           ownedByClient: true,                // Make sure the RealtimeView on this prefab is owned by this client
                preventOwnershipTakeover: true,                // Prevent other clients from calling RequestOwnership() on the root RealtimeView.
                             useInstance: realtime);           // Use the instance of Realtime that fired the didConnectToRoom event.
        }
    }
}
