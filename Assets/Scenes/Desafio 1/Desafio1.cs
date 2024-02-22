using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio1 : MonoBehaviour
{
    public int firstNumber;
    public int secondNumber;

   
    // Start is called before the first frame update
    void Start()
    {
        int soma = firstNumber + secondNumber;
        Debug.Log($"O Resultado da soma de {firstNumber} e {secondNumber} é: {soma}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
