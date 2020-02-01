using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomizationSelector : MonoBehaviour
{
    [SerializeField]
    private Text selectedText;
    [SerializeField]
    private PlayerPreferences PlayerPreferences;

    public void NextItem()
    {
        selectedText.text = "Bunny Ears";
        PlayerPreferences.BunnyEars = true;
    }

    public void PreviousItem()
    {
        selectedText.text = "None";
        PlayerPreferences.BunnyEars = false;
    }
}
