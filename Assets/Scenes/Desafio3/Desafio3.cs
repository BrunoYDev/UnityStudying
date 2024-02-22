using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio3 : MonoBehaviour
{

    public string letter;
    // Start is called before the first frame update
    void Start()
    {
        switch (letter)
        {
            case "a":
                Debug.Log("Vogal");
                break;
            case "e":
                Debug.Log("Vogal");
                break;
            case "i":
                Debug.Log("Vogal");
                break;
            case "o":
                Debug.Log("Vogal");
                break;
            case "u":
                Debug.Log("Vogal");
                break;
            default:
                Debug.Log("Consoante ou Inválido");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
