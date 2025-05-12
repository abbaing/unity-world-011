using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample02 : MonoBehaviour
{
    public GameObject[] cubes;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cubes[0].SetActive(false);
            cubes[1].SetActive(false);
            cubes[2].SetActive(false);
        }
    }
}
