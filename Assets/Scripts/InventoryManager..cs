using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance; // Singleton ��� �������� �������

    public Image itemSlot; // Image �� Canvas ��� ����������� ��������
    private Item currentItem;

    private void Awake()
    {
        // �������� �� ������� ������� ���������
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
            itemSlot.gameObject.SetActive(true); // �������� ������ Slot �������!
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
        currentItem = null; // ������� ������ �� �������
        itemSlot.sprite = null; // ������� ������
        itemSlot.gameObject.SetActive(false); // ��������� ��� ����
    }
}
