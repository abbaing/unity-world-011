using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample03 : MonoBehaviour
{
    public GameObject[] cubes;
    private int index = 0;
    private int max = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (index < max)
            {
                cubes[index].SetActive(false);
                index++;
            }
        }
    }
}
