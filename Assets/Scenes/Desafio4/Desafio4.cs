using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio4 : MonoBehaviour
{

    public int num1;
    public int num2;
    public int num3;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2 && num1 == num3)
        {
            Debug.Log("Traingulo Equilátero");
        }
        else if (num1 == num2 || num1 == num3 || num2 == num3)
        {
            Debug.Log("Triangulo Isósceles");
        }
        else
        {
            Debug.Log("Triangulo Escaleno");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
