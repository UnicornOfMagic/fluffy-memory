using System;
using UnityEngine;
using UnityEngine.UI;

public class CustomizationSelector : MonoBehaviour
{
    [SerializeField]
    private Text selectedText = null;
    [SerializeField]
    private PlayerPreferences PlayerPreferences = null;

    public void NextItem()
    {
        var item = GetNextItem();
        selectedText.text = item.ToString();
        PlayerPreferences.Customization = item;
    }

    public void PreviousItem()
    {
        var item = GetPreviousItem();
        selectedText.text = item.ToString();
        PlayerPreferences.Customization = item;
    }

    private Customizations GetNextItem()
    {
        var count = Enum.GetValues(typeof(Customizations)).Length;

        var currentItem = PlayerPreferences.Customization;
        if ((int)currentItem == count - 1)
        {
            return 0;
        } else
        {
            return (Customizations)((int)currentItem + 1);
        }
    }

    private Customizations GetPreviousItem()
    {
        var count = Enum.GetValues(typeof(Customizations)).Length;
        var currentItem = PlayerPreferences.Customization;
        if (currentItem == 0)
        {
            return (Customizations)(count - 1);
        }
        else
        {
            return (Customizations)((int)currentItem - 1);
        }
    }
}
