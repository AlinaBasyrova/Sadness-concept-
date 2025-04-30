using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance; // Singleton для удобного доступа

    public Image itemSlot; // Image на Canvas для отображения предмета
    private Item currentItem;

    private void Awake()
    {
        // Проверка на наличие второго инвентаря
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool AddItem(Item newItem)
    {
        if (currentItem == null)
        {
            currentItem = newItem;
            itemSlot.gameObject.SetActive(true); // Включаем объект Slot целиком!
            itemSlot.sprite = currentItem.itemIcon;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void ClearItem()
    {
        currentItem = null; // Убираем ссылку на предмет
        itemSlot.sprite = null; // Очищаем иконку
        itemSlot.gameObject.SetActive(false); // Выключаем сам слот
    }
}
