using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Image[] slots;
    public List<Item> inventoryItems = new List<Item>();
    public InventoryUI inventoryUI;


    public bool AddItem(Item newItem)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i].sprite == null)
            {
                slots[i].sprite = newItem.icon;
                slots[i].color = Color.white;
                inventoryItems.Add(newItem);
                Debug.Log("Item added: " + newItem.itemName);
                return true;
            }
        }

        Debug.Log("Inventory full!");
        if (inventoryUI != null)
            inventoryUI.ShowInventoryFullMessage();
        return false;
    }
}
