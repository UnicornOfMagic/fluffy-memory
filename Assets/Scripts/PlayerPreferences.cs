using UnityEngine;

public class PlayerPreferences : MonoBehaviour
{
    public Customizations Customization;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }
}

public enum Customizations
{
    None,
    BunnyEars
}