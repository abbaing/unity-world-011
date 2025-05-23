using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cursors : MonoBehaviour
{
    public GameObject cursorObject;
    public Sprite cursorBasic;
    public Sprite cursorHand;
    public Image cursorImage;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        cursorObject.transform.position = Input.mousePosition;

        if (Input.GetMouseButton(1))
        {
            cursorImage.sprite = cursorHand;
        }
        if (Input.GetMouseButtonUp(1))
        {
            cursorImage.sprite = cursorBasic;
        }
    }
}
