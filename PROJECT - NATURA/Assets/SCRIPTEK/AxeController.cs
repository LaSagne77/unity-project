using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeController : MonoBehaviour
{
    public float chopForce = 10f;

    void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Call a method to use the axe
            UseAxe();
        }
    }

    void UseAxe()
    {
        // Perform actions when the axe is used
        // For example, you can add sound effects, animations, or chop trees.

        // Check if the axe hit something
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Check if the hit object is a tree (you might have a specific tag or layer for trees)
            if (hit.collider.CompareTag("Tree"))
            {
                // Apply force to the tree to simulate chopping
                Rigidbody treeRb = hit.collider.GetComponent<Rigidbody>();
                if (treeRb != null)
                {
                    treeRb.AddForce(Vector3.forward * chopForce, ForceMode.Impulse);
                }
            }
        }
    }
}