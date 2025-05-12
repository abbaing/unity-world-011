using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TavernMessageBox : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text buttonText;
    public Color32 MessageOff;
    public Color32 MessageOn;
    public Text shopOwnerMessage;
    public GameObject ShopForm;

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        buttonText.color = MessageOn;
        PlayerMove.canMove = false;
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        buttonText.color = MessageOff;
        PlayerMove.canMove = true;
    }

    void Start()
    {
        shopOwnerMessage.text = "Hello " + 
            SaveCharacter.characterName + 
            ", how can I help you?";
    }

    void Update()
    {
        if (PlayerMove.canMove && PlayerMove.moving && ShopForm != null)
        {
            ShopForm.SetActive(false);
        }
    }

    public void MessageNothingImportant()
    {
        shopOwnerMessage.text = "Not much going on around here";
    }

    public void MessageBuy()
    {
        shopOwnerMessage.text = "Select items from the list";
        ShopForm.SetActive(true);
        ShopForm.GetComponent<TavernBuy>().UpdateGold();
    }
}
