using UnityEngine;

public class GameWindowController : MonoBehaviour
{
    public GameObject window;

    public void OpenWindow()
    {
        window.SetActive(true);
    }

    public void CloseWindow()
    {
        window.SetActive(false);
    }
}
