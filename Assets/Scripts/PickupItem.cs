using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public ItemData itemData;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Inventory.Instance.AddItem(itemData);
            UIManager.Instance.ShowMemory(itemData);
            Destroy(gameObject);
        }
    }
}
