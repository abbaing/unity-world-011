using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public int number;
    public bool redMushoom = false;
    public bool purpleMushoom = false;
    public bool brownMushoom = false;
    public bool blueFlower = false;
    public bool redFlower = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (redMushoom)
            {
                if (InventoryItems.redMushooms == 0) DisplayIcons();
                InventoryItems.redMushooms++;
            }
            else if (purpleMushoom)
            {
                if (InventoryItems.purpleMushooms == 0) DisplayIcons();
                InventoryItems.purpleMushooms++;
            }
            else if (brownMushoom)
            {
                if (InventoryItems.brownMushooms == 0) DisplayIcons();
                InventoryItems.brownMushooms++;
            }
            else if (blueFlower)
            {
                if (InventoryItems.blueFlowers == 0) DisplayIcons();
                InventoryItems.blueFlowers++;
            }
            else if (redFlower)
            {
                if (InventoryItems.redFlowers == 0) DisplayIcons();
                InventoryItems.redFlowers++;
            }
            else
            {
                DisplayIcons();
            }
            Destroy(gameObject);
        }
    }

    private void DisplayIcons()
    {
        InventoryItems.newIcon = number;
        InventoryItems.iconUpdate = true;
    }
}
