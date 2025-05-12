using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TavernBuy : MonoBehaviour
{
    public GameObject ShopForm;

    public int[] amounts;
    public int[] costs;
    public int[] iconNumbers;
    public int[] inventoryItems;
    public Text[] itemAmountTexts;
    public Text currencyText;
    private Text compare;
    public bool tavern;
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
                        if (tavern)
                        {
                            UpdateTavernAmount();
                        }
                        if (InventoryItems.gold >= costs[i])
                        {
                            if (inventoryItems[i] == 0)
                            {
                                InventoryItems.newIcon = iconNumbers[i];
                                InventoryItems.iconUpdate = true;
                            }
                            InventoryItems.gold -= costs[i];
                            if (tavern)
                            {
                                SetTavernAmount(i);
                            }
                        }
                    }
                }
            }
        }
    }

    void UpdateTavernAmount()
    {
        inventoryItems[0] = InventoryItems.bread;
        inventoryItems[1] = InventoryItems.cheese;
        inventoryItems[2] = InventoryItems.meat;
    }

    void SetTavernAmount(int item)
    {
        switch (item)
        {
            case 0:
                InventoryItems.bread++;
                break;
            case 1:
                InventoryItems.cheese++;
                break;
            case 2:
                InventoryItems.meat++;
                break;
        }
        amounts[item]--;
        itemAmountTexts[item].text = amounts[item].ToString();
        currencyText.text = InventoryItems.gold.ToString();
        max = itemAmountTexts.Length;
    }

    public void SetBuyingBread()
    {
        compare = itemAmountTexts[0];
        Check(0);
    }

    public void SetBuyingCheese()
    {
        compare = itemAmountTexts[1];
        Check(1);
    }

    public void SetBuyingMeat()
    {
        compare = itemAmountTexts[2];
        Check(2);
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
