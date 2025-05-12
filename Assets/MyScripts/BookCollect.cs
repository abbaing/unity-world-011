using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCollect : MonoBehaviour
{
    public GameObject magicUI;
    public GameObject spellsUI;
    private bool isMagicCollected = false;
    private bool isSpellCollected = false;
    public bool isMagicBook;
    public bool isSpellsBook;

    // Start is called before the first frame update
    void Start()
    {
        spellsUI.SetActive(false);
        magicUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (isMagicBook && !isMagicCollected)
            {
                magicUI.SetActive(true);
                isMagicCollected = true;
            }
            if (isSpellsBook && !isSpellCollected)
            {
                spellsUI.SetActive(true);
                isSpellCollected = true;
            }
        }
    }
}
