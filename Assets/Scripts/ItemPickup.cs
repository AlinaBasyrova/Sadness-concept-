using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item; // ����� ������� ���������

    private void OnMouseDown()
    {
        if (InventoryManager.Instance.AddItem(item))
        {
            Destroy(gameObject); // �����: ������� �������
        }
        else
        {
            Debug.Log("��������� �����!");
            // ������� �� ��������� �� �����, ������ ��� ���� �����
        }
    }
}
