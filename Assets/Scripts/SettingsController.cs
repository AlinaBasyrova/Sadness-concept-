using UnityEngine.SceneManagement;
using UnityEngine;

public class SettingsController : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
