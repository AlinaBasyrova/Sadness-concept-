using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InventoryUI : MonoBehaviour
{
    public GameObject fullInventoryMessage; // —юда перетаскиваем Text
    public float messageDuration = 2f;
    void Start()
    {
        fullInventoryMessage.SetActive(false);
    }

    public void ShowInventoryFullMessage()
    {
        StartCoroutine(ShowMessageCoroutine());
    }

    private IEnumerator ShowMessageCoroutine()
    {
        fullInventoryMessage.SetActive(true);
        yield return new WaitForSeconds(messageDuration);
        fullInventoryMessage.SetActive(false);
    }
}
