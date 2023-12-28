using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private GameObject inventoryUI;

    private void Start()
    {
        // Get a reference to the inventory UI game object
        inventoryUI = GameObject.Find("MainInventory"); // Replace "InventoryUI" with the actual name of your inventory UI object
        if (inventoryUI != null)
        {
            // Disable the inventory at the start
            inventoryUI.SetActive(false);
        }
    }

    private void Update()
    {
        // Check for input or other conditions to toggle the inventory
        if (Input.GetKeyDown(KeyCode.I))
        {
            ToggleInventory();
        }
    }

    private void ToggleInventory()
    {
        // Toggle the visibility of the inventory
        if (inventoryUI != null)
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
    }
}