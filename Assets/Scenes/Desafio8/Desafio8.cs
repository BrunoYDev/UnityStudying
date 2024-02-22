using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Desafio8 : MonoBehaviour
{
    public InputField player1Name;
    public InputField player1NumberChoice;
    public InputField player1ZeroOneChoice;
    
    public Text whoWins;

    public Text player2NumberChoice;

    int element1;
    int element2;

    public void PlayGame()
    {
        try
        {
            element1 = Int32.Parse(player1NumberChoice.text);
            element2 = Int32.Parse(player2NumberChoice.text);

            whoWins.text = oddOrEven();
        }
        catch (FormatException e)
        {
            whoWins.text = "Por favor insira um número válido";
        }
        
    }
    string oddOrEven()
    {
        string playerZeroOneChoiceNormalizer = player1ZeroOneChoice.text.ToLower();
        if(!player1Name.text.Equals(""))
        {
            if (playerZeroOneChoiceNormalizer == "par")
            {
                if ((element1 + element2) % 2 == 0)
                {
                    return $"Jogador {player1Name.text} Venceu!!";
                }
                return "O PC venceu!!";
            }
            if (playerZeroOneChoiceNormalizer == "impar")
            {
                if ((element1 + element2) % 2 == 1)
                {
                    return $"Jogador {player1Name.text} Venceu!!";
                }
                return "O PC venceu!!";
            }
            return "Insira ou par ou impar";
        }
        return "Insira um nome";
    }
        
}


