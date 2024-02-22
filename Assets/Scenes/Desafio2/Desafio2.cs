using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{

    public int num1 = 0;

    public int num2 = 0;

    public int num3 = 0;

    int majorNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        majorNumber = num1;
        
        if(num2 > majorNumber)
        {
            majorNumber = num2;
        }
        if (num3 > majorNumber)
        {
            majorNumber = num3;
        }

        Debug.Log($"O maior numero é o {majorNumber}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
