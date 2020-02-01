using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePauseMenu : MonoBehaviour
{
    [SerializeField]
    GameObject pauseMenu;

    [SerializeField]
    bool isShowing = false;
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void ToggleMenuActive()
    {
        isShowing = !isShowing;
        pauseMenu.SetActive(isShowing);
    }
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            ToggleMenuActive();
        }
    }


}
