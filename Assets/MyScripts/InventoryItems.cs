using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour
{
    public GameObject inventoryMenu;
    public GameObject openBook;
    public GameObject closeBook;

    public Image[] emptySlots;
    public Sprite[] icons;
    public Sprite emptyIcon;

    public static int newIcon = 0;
    public static bool iconUpdate = false;
    private int max;

    public static int redMushooms = 0;
    public static int purpleMushooms = 0;
    public static int brownMushooms = 0;
    public static int blueFlowers = 0;
    public static int redFlowers = 0;
    public static int bread = 0;
    public static int cheese = 0;
    public static int meat = 0;
    
    public static int redPotion = 0;
    public static int purplePotion = 0;
    public static int bluePotion = 0;
    public static int greenPotion = 0;
    public static int dragonEgg = 0;
    public static int roots = 0;
    public static int leafDew = 0;

    public static bool key = true;
    public static int gold = 300;
    public GameObject messageBox;

    // Start is called before the first frame update
    void Start()
    {
        CloseMenu();
        max = emptySlots.Length;

        //Temporal
        redMushooms = 0;
        purpleMushooms = 0;
        brownMushooms = 0;
        blueFlowers = 0;
        redFlowers = 0;
        redPotion = 0;
        purplePotion = 0;
        bluePotion = 0;
        greenPotion = 0;
        dragonEgg = 0;
        roots = 0;
        leafDew = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (iconUpdate)
        {
            for(int i = 0; i < max; i++)
            {
                if (emptySlots[i].sprite == emptyIcon)
                {
                    max = i;
                    emptySlots[i].sprite = icons[newIcon];
                    emptySlots[i].transform.gameObject.GetComponent<HintMessage>().objectType = newIcon;
                }
            }
            StartCoroutine(Reset());
        }
    }

    public void OpenMenu()
    {
        inventoryMenu.SetActive(true);
        openBook.SetActive(true);
        closeBook.SetActive(false);
        messageBox.SetActive(false);
        Time.timeScale = 0;
    }

    public void CloseMenu()
    {
        inventoryMenu.SetActive(false);
        openBook.SetActive(false);
        closeBook.SetActive(true);
        Time.timeScale = 1;
    }

    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(0.1f);
        iconUpdate = false;
        max = emptySlots.Length;
    }
}
