using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Inventory playerInventory;
    public GameObject inventoryUI; // Reference to the UI canvas

    void Update()
    {
        // Add logic to open/close the inventory UI (e.g., press a key)
        if (Input.GetKeyDown(KeyCode.I))
        {
            ToggleInventoryUI();
        }
    }

    void ToggleInventoryUI()
    {
        inventoryUI.SetActive(!inventoryUI.activeSelf);
    }
}