using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicBook : MonoBehaviour
{
    public Image magicIcon;
    public Text magicName;
    public Text magicDescription;
    public Sprite[] magicSprites;
    public string[] magicNames;
    public string[] magicDescriptions;
    public GameObject[] iconSets;
    private int currentIcon = 0;

    // Start is called before the first frame update
    void Start()
    {
        EnableSet(0);
    }

    // Update is called once per frame
    void EnableSet(int index)
    {
        magicIcon.sprite = magicSprites[index];
        magicName.text = magicNames[index];
        magicDescription.text = magicDescriptions[index];
        SwitchOff();
        iconSets[index].SetActive(true);
    }

    public void Next()
    {
        if (currentIcon < magicSprites.Length - 1)
        {
            currentIcon++;
            EnableSet(currentIcon);
        }
    }

    public void Back()
    {
        if (currentIcon > 0)
        {
            currentIcon--;
            EnableSet(currentIcon);
        }
    }

    void SwitchOff()
    {
        for(int i = 0; i < magicSprites.Length; i++)
        {
            iconSets[i].SetActive(false);
        }
    }
}
