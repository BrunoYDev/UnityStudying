using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Desafio7 : MonoBehaviour
{
    int resource = 0;
    int clickVar = 1;
    public Text counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        resource += clickVar;
        counter.text = resource.ToString();
        Debug.Log($"Recursos atuais {resource}");
    }

    public void upgrade(int upgradeCost)
    {
        if (upgradeCost <= resource)
        {
            resource -= upgradeCost;
            clickVar += upgradeCost / 10;
            Debug.Log("fez o upgrade");
        }
        else
        {
            Debug.Log($"Recursos insuficientes, Apenas {resource}");
        }
    }
}
