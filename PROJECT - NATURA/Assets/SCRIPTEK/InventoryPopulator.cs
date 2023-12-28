using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Inventory playerInventory;
    public Transform itemSlotParent; // The parent object for item slots
    public GameObject itemSlotPrefab; // Prefab for the item slot

    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        // Clear existing slots
        foreach (Transform child in itemSlotParent)
        {
            Destroy(child.gameObject);
        }

        // Populate UI with items from the inventory
        foreach (Item item in playerInventory.items)
        {
            GameObject slot = Instantiate(itemSlotPrefab, itemSlotParent);
            Image icon = slot.transform.Find("Icon").GetComponent<Image>();
            Text quantityText = slot.transform.Find("Quantity").GetComponent<Text>();

            icon.sprite = item.icon;
            quantityText.text = item.quantity.ToString();
        }
    }
}