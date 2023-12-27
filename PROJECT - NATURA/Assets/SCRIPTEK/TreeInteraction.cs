using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeInteraction : MonoBehaviour
{
    public GameObject woodPrefab;

    // Adjust these parameters to control the wood drop behavior
    public int woodCount = 3; // Number of wood pieces to drop
    public float dropForce = 5f;

    void Update()
    {
        
                    // Call a method to destroy the tree
                   DestroyTree();


    }

    void DestroyTree()
    {
        // Instantiate wood pieces
        for (int i = 0; i < woodCount; i++)
        {
            GameObject wood = Instantiate(woodPrefab, transform.position, Quaternion.identity);
            Rigidbody woodRb = wood.GetComponent<Rigidbody>();

            // Apply force to make wood pieces fly in different directions
            woodRb.AddForce(new Vector3(Random.Range(-1f, 1f), 1f, Random.Range(-1f, 1f)) * dropForce, ForceMode.Impulse);
        }

        // Destroy the tree
        Destroy(gameObject);
    }
}