using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HintMessage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject hintBox;
    public Text message;

    private Vector3 screenPoint;

    private bool isDisplaying = true;
    private bool isOverIcon = false;

    public int objectType = 0;

    void Start()
    {
        hintBox.SetActive(false);
    }

    void Update()
    {
        if (isOverIcon &&
            Input.GetMouseButtonDown(0))
        {
            isDisplaying = false;
            hintBox.SetActive(false);
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDisplaying = true;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isOverIcon = true;
        if (isDisplaying)
        {
            hintBox.SetActive(true);
            SetScreenPoint();
            SetHintboxPosition();
            MessageDisplay();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isOverIcon = false;
        hintBox.SetActive(false);
    }

    private void SetScreenPoint()
    {
        screenPoint.x = Input.mousePosition.x + 600;
        screenPoint.y = Input.mousePosition.y;
        screenPoint.z = 1f;
    }
    
    private void SetHintboxPosition()
    {
        hintBox.transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
    }

    private void MessageDisplay()
    {
        switch (objectType)
        {
            case 1:
                message.text = InventoryItems.blueFlowers.ToString() +
                    " blue flowers to be used in potions";
                break;
            case 13:
                message.text = InventoryItems.redFlowers.ToString() +
                    " red flowers to be used in potions";
                break;
            case 14:
                message.text = InventoryItems.redMushooms.ToString() +
                    " red mushooms to be used in potions";
                break;
            default:
                message.text = "Empty";
                break;
        }
    }
}
