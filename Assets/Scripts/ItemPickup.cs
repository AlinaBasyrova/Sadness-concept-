using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item itemToAdd;

    private void OnMouseDown()
    {
        bool added = inventoryManager.AddItem(itemToAdd);
        if (added)
        {
            Destroy(gameObject);
        }
    }
}
