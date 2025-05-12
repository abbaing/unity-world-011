using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WizardBuy : MonoBehaviour
{
    public GameObject ShopForm;

    public int[] amounts;
    public int[] costs;
    public int[] iconNumbers;
    public int[] inventoryItems;
    public Text[] itemAmountTexts;
    public Text currencyText;
    private Text compare;
    public bool Wizard;
    private int max = 0;
    private bool canBuy;

    // Start is called before the first frame update
    void Start()
    {
        max = itemAmountTexts.Length;
        currencyText.text = InventoryItems.gold.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseForm()
    {
        ShopForm.SetActive(false);
    }

    public void Buy()
    {
        if (canBuy)
        {
            for (int i = 0; i < max; i++)
            {
                if (itemAmountTexts[i] == compare)
                {
                    max = i;
                    if (amounts[i] > 0)
                    {
                        if (Wizard)
                        {
                            UpdateWizardAmount();
                        }
                        if (InventoryItems.gold >= costs[i])
                        {
                            if (inventoryItems[i] == 0)
                            {
                                InventoryItems.newIcon = iconNumbers[i];
                                InventoryItems.iconUpdate = true;
                            }
                            InventoryItems.gold -= costs[i];
                            if (Wizard)
                            {
                                SetWizardAmount(i);
                            }
                        }
                    }
                }
            }
        }
    }

    void UpdateWizardAmount()
    {
        inventoryItems[0] = InventoryItems.redPotion;
        inventoryItems[1] = InventoryItems.purplePotion;
        inventoryItems[2] = InventoryItems.bluePotion;
        inventoryItems[3] = InventoryItems.greenPotion;
        inventoryItems[4] = InventoryItems.dragonEgg;
        inventoryItems[5] = InventoryItems.roots;
        inventoryItems[6] = InventoryItems.leafDew;
    }

    void SetWizardAmount(int item)
    {
        switch (item)
        {
            case 0:
                InventoryItems.redPotion++;
                break;
            case 1:
                InventoryItems.purplePotion++;
                break;
            case 2:
                InventoryItems.bluePotion++;
                break;
            case 3:
                InventoryItems.greenPotion++;
                break;
            case 4:
                InventoryItems.dragonEgg++;
                break;
            case 5:
                InventoryItems.roots++;
                break;
            case 6:
                InventoryItems.leafDew++;
                break;
        }
        amounts[item]--;
        itemAmountTexts[item].text = amounts[item].ToString();
        currencyText.text = InventoryItems.gold.ToString();
        max = itemAmountTexts.Length;
    }

    public void SetBuyingRedPotion()
    {
        compare = itemAmountTexts[0];
        Check(0);
    }

    public void SetBuyingPurplePotion()
    {
        compare = itemAmountTexts[1];
        Check(1);
    }

    public void SetBuyingBluePotion()
    {
        compare = itemAmountTexts[2];
        Check(2);
    }

    public void SetBuyingGreenPotion()
    {
        compare = itemAmountTexts[3];
        Check(3);
    }

    public void SetBuyingDragonEgg()
    {
        compare = itemAmountTexts[4];
        Check(4);
    }

    public void SetBuyingRoots()
    {
        compare = itemAmountTexts[5];
        Check(5);
    }

    public void SetBuyingLeafDew()
    {
        compare = itemAmountTexts[6];
        Check(6);
    }

    void Check(int item)
    {
        if (amounts[item] > 0)
        {
            canBuy = true;
        }
        else
        {
            canBuy = false;
        }
    }

    public void UpdateGold()
    {
        currencyText.text = InventoryItems.gold.ToString();
    }
}
