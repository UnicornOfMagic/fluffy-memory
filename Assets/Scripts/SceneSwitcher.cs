using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoGameScene()
    {
        SceneManager.LoadScene("GameScene001");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
