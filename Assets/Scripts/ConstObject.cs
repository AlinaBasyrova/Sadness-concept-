using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public GameWindowController gameWindow;

    private void OnMouseDown()
    {
        gameWindow.OpenWindow();
    }
}
