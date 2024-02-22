using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Desafio6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(greaterThanThousand(500, 600, 15));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool greaterThanThousand(int x, int y, int z)
    {
        bool result = (x + y) * z > 1000;

        if (result)
        {
            return true;
        }
        return false;
    }
}
