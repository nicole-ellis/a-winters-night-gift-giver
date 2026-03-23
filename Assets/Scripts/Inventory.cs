using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public List<ItemData> collectedItems = new List<ItemData>();

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void AddItem(ItemData item)
    {
        if (!collectedItems.Contains(item))
        {
            collectedItems.Add(item);
        }
    }

    public bool HasAllItems(int total)
    {
        return collectedItems.Count >= total;
    }
}