using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio5 : MonoBehaviour
{

    public string player1;
    public string player2;

    public int p1Choice;
    public int p2Choice;

    // Start is called before the first frame update
    void Start()
    {
        int result = (p1Choice + p2Choice) % 2;

        if(result == 0)
        {
            Debug.Log($"{player1} ganhou o numero {p1Choice + p2Choice} é par ");
        }
        else
        {
            Debug.Log($"{player2} ganhou o numero {p1Choice + p2Choice} é Impar ");
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
