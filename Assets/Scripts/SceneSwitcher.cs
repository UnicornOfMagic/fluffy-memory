using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField]
    public Canvas MainCanvas = null;
    [SerializeField]
    private Canvas CustomizeCanvas = null;

    public void GotoGameScene()
    {
        SceneManager.LoadScene("GameScene001");
    }

    public void GoToCustomizationScreen()
    {
        MainCanvas.enabled = false;
        CustomizeCanvas.enabled = true;
    }

    public void GoToMainMenu()
    {
        MainCanvas.enabled = true;
        CustomizeCanvas.enabled = false;
    }
}
