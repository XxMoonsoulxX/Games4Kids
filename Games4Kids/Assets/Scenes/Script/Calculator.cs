using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    int primeValue, secondValue, tempValue, finalAnswer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) // summa
        {
            CalcularFn("summa");
        }

        if (Input.GetKeyDown(KeyCode.R)) // vähennys
        {
            CalcularFn("vähennys");
        }

        if (Input.GetKeyDown(KeyCode.M)) // kerto
        {
            CalcularFn("kerto");
        }

        if (Input.GetKeyDown(KeyCode.D)) // jako
        {
            CalcularFn("jako");
        }
    }

    public void CalcularFn(string operation)
    {
        primeValue = Random.Range(1,10);
        secondValue = Random.Range(1, 10);

        if (primeValue-secondValue <0)
        {
            tempValue = secondValue;
            secondValue = primeValue;
            primeValue = tempValue;
        }

        if (operation == "summa")
        {
            finalAnswer = primeValue + secondValue;
        }

        if (operation == "vähennys")
        {
            finalAnswer = primeValue - secondValue;
        }

        if (operation == "kerto")
        {
            finalAnswer = primeValue * secondValue;
        }

        if (operation == "jako")
        {
            finalAnswer = primeValue / secondValue;
        }


        Debug.Log("1Value: " + primeValue + " 2value: " + secondValue + "Answer is : "+ finalAnswer);
    }
}
