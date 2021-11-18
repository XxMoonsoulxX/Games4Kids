using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    int primeValue, secondValue, tempValue, finalAnswer, Alternative1, Alternative2;
    public Animator AnimatorBack;
    public Text PrimeDigit, SecondDigit, Sign, Alt_1, Alt_2, Alt_3;
    public Texture TextureSum, TextureReduce, TextureDivide, TextureMultiply;
    private string TempoOp, VarSign;
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(false);
        GameObject.Find("Main Camera").transform.position = new Vector3(0f, 0f, -10f);
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

    public void FunctionSum()
    {
        TempoOp = "sums";
        NewSection();
    }

    public void FunctionReduce()
    {
        TempoOp = "reduces";
        NewSection();
    }

    public void FunctionDivide()
    {
        TempoOp = "divides";
        NewSection();
    }

    public void FunctionMultiply()
    {
        TempoOp = "multiples";
        NewSection();
    }

    private void NewSection()
    {
        AnimatorBack = GameObject.Find("Background").GetComponent<Animator>();
        AnimatorBack.Play("Begin");
    }

    public void AmoveCamera()
    {
        GameObject.Find("Main Camera").transform.position = new Vector3(20f, 0f, -10f);

        if (TempoOp == "sums") { CalcularFn("sum");            GameObject.Find("BackgroundAfter").GetComponent<Renderer>().material.mainTexture = TextureSum; }
        if (TempoOp == "reduces") { CalcularFn("reduce");      GameObject.Find("BackgroundAfter").GetComponent<Renderer>().material.mainTexture = TextureReduce; }
        if (TempoOp == "divides") { CalcularFn("divide");      GameObject.Find("BackgroundAfter").GetComponent<Renderer>().material.mainTexture = TextureDivide; }
        if (TempoOp == "multiples") { CalcularFn("multiply");  GameObject.Find("BackgroundAfter").GetComponent<Renderer>().material.mainTexture = TextureMultiply; }

        Canvas.SetActive(true);
    }

    public void ReturnMenu()
    {
        Canvas.SetActive(false);
        GameObject.Find("Main Camera").transform.position = new Vector3(0f, 0f, -10f);
        AnimatorBack = GameObject.Find("Background").GetComponent<Animator>();
        AnimatorBack.Play("Start");
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
            VarSign = "sum";
        }

        if (operation == "reduce")
        {
            finalAnswer = primeValue - secondValue;
            VarSign = "reduce";
        }

        if (operation == "divide")
        {
            finalAnswer = primeValue / secondValue;
            Debug.Log("Division: " + finalAnswer);
            VarSign = "divide";
        }

        if (operation == "multiply")
        {
            finalAnswer = primeValue * secondValue;
            VarSign = "multiply";
        }

        Debug.Log("1Value: " + primeValue + " 2value: " + secondValue + "Answer is : " + finalAnswer); // For pressing Letter S,R,M and D

        PrimeDigit.text = primeValue.ToString();
        SecondDigit.text = secondValue.ToString();

        if (VarSign == "sum")
        {
            Sign.text = "+";
        }

        if (VarSign == "reduce")
        {
            Sign.text = "-";
        }

        if (VarSign == "divide")
        {
            Sign.text = "÷";
        }

        if (VarSign == "multiply")
        {
            Sign.text = "×";
        }

        // PRIMER ALTERNATIVE
        tempValue = Random.Range(2, 20);
        while (tempValue == finalAnswer)
        {
            tempValue = Random.Range(2, 20);
        }
        Alternative1 = tempValue;

        // SECOND ALTERNATIVE
        tempValue = Random.Range(2, 20);
        while ((tempValue == finalAnswer) || (tempValue == Alternative1))
        {
            tempValue = Random.Range(2, 20);
        }
        Alternative2 = tempValue;

        Debug.Log("Alternatives: " + Alternative1 + " - " + Alternative2 + " - " + finalAnswer);


        tempValue = Random.Range(1, 7);
        if (tempValue == 1)
        {
            Alt_1.text = finalAnswer.ToString(); Alt_2.text = Alternative1.ToString(); Alt_3.text = Alternative2.ToString();
            Debug.Log("tempValue1");
        }
        if (tempValue == 2)
        {
            Alt_1.text = finalAnswer.ToString(); Alt_2.text = Alternative2.ToString(); Alt_3.text = Alternative1.ToString();
            Debug.Log("tempValue2");
        }
        if (tempValue == 3)
        {
            Alt_1.text = Alternative1.ToString(); Alt_2.text = finalAnswer.ToString(); Alt_3.text = Alternative2.ToString();
            Debug.Log("tempValue3");
        }
        if (tempValue == 4)
        {
            Alt_1.text = Alternative1.ToString(); Alt_2.text = Alternative2.ToString(); Alt_3.text = finalAnswer.ToString();
            Debug.Log("tempValue4");
        }
        if (tempValue == 5)
        {
            Alt_1.text = Alternative2.ToString(); Alt_2.text = finalAnswer.ToString(); Alt_3.text = Alternative1.ToString();
            Debug.Log("tempValue5");
        }
        if (tempValue == 6)
        {
            Alt_1.text = Alternative2.ToString(); Alt_2.text = Alternative1.ToString(); Alt_3.text = finalAnswer.ToString();
            Debug.Log("tempValue6");
        }
        if (tempValue == 7)
        {
            Alt_1.text = Alternative2.ToString(); Alt_2.text = Alternative1.ToString(); Alt_3.text = finalAnswer.ToString();
            Debug.Log("tempValue7");
        }

    }
}
