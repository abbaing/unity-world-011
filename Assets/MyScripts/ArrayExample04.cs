using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample04 : MonoBehaviour
{
    public GameObject[] cubes;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < cubes.Length; i++)
            {
                cubes[i].SetActive(false);
            }
        }
    }
}
