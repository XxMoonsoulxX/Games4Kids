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
            CalcularFn("sum");
        }

        if (Input.GetKeyDown(KeyCode.R)) // vähennys
        {
            CalcularFn("reduce");
        }

        if (Input.GetKeyDown(KeyCode.M)) // kerto
        {
            CalcularFn("multiply");
        }

        if (Input.GetKeyDown(KeyCode.D)) // jako
        {
            CalcularFn("divide");
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

        if (operation == "sum")
        {
            finalAnswer = primeValue + secondValue;
        }

        if (operation == "reduce")
        {
            finalAnswer = primeValue - secondValue;
        }

        if (operation == "multiply")
        {
            finalAnswer = primeValue * secondValue;
        }

        if (operation == "divide")
        {
            finalAnswer = primeValue / secondValue;
        }


        Debug.Log("1Value: " + primeValue + " 2value: " + secondValue + "Answer is : "+ finalAnswer);
    }
}
