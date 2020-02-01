using UnityEngine;

public class PlayerPreferences : MonoBehaviour
{
    public bool BunnyEars = false;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }
}
