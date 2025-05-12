using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseCharacter : MonoBehaviour
{
    public GameObject[] characters;
    private int selectedCharacter;
    public Text characterName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        if (selectedCharacter < characters.Length)
        {
            characters[selectedCharacter].SetActive(false);
            selectedCharacter++;

            if (selectedCharacter == characters.Length)
            {
                selectedCharacter = 0;
            }

            characters[selectedCharacter].SetActive(true);
        }
    }

    public void Previous()
    {
        if (selectedCharacter >= 0)
        {
            characters[selectedCharacter].SetActive(false);
            selectedCharacter--;

            if (selectedCharacter < 0)
            {
                selectedCharacter = characters.Length - 1;
            }

            characters[selectedCharacter].SetActive(true);
        }
    }

    public void Accept()
    {
        SaveCharacter.characterId = selectedCharacter;
        SaveCharacter.characterName = characterName.text;

        SceneManager.LoadScene(1);
    }
}
