using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestBehavior : MonoBehaviour
{
    private Animator animator;
    public int goldAmt = 50;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && InventoryItems.key)
        {
            animator.SetTrigger("open");
            InventoryItems.gold += goldAmt;
            goldAmt = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && InventoryItems.key)
        {
            animator.SetTrigger("close");
        }
    }
}
