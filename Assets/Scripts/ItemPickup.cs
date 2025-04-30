using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item; // Какой предмет подбираем

    private void OnMouseDown()
    {
        if (InventoryManager.Instance.AddItem(item))
        {
            Destroy(gameObject); // Успех: убираем предмет
        }
        else
        {
            Debug.Log("Инвентарь полон!");
            // Предмет не убирается со сцены, потому что слот занят
        }
    }
}
