using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    // Reference to the broken tree prefab
    public GameObject brokenTreePrefab;

    // Threshold force to break the tree
    public float breakForce = 10f;

    // Update is called once per frame
    void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Raycast to check if the mouse click hits the tree
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit object is the tree
                if (hit.collider.gameObject == gameObject)
                {
                    // Call a method to break the tree
                    BreakTree();
                }
            }
        }
    }

    // Method to break the tree
    private void BreakTree()
    {
        // Instantiate broken tree parts at the tree's position
        Instantiate(brokenTreePrefab, transform.position, transform.rotation);

        // Optionally, add any additional effects or logic for breaking the tree
        // For example, you can play a breaking sound, disable the original tree, etc.

        // Destroy the original tree GameObject
        Destroy(gameObject);
    }
}