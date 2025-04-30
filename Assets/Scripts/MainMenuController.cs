using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Wall1_Floor1"); //
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("SettingsScene");
    }
}