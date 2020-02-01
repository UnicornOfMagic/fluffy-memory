using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    [SerializeField]
    GameObject inGameMenu;

    [SerializeField]
    bool isShowing = false;
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void ToggleMenuActive()
    {
        isShowing = !isShowing;
        inGameMenu.SetActive(isShowing);
    }
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            ToggleMenuActive();
        }
    }


}
