using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    void Start()
    {
        ShowMultiples();
    }

    void ShowMultiples()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log("Múltiplo de 3: " + i);
            }

            if (i % 2 == 0)
            {
                Debug.Log("Múltiplo de 2: " + i);
            }
        }
    }
}

