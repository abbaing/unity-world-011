using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample01 : MonoBehaviour
{
    public GameObject cube01, cube02, cube03;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cube01.SetActive(false);
            cube02.SetActive(false);
            cube03.SetActive(false);
        }
    }
}
