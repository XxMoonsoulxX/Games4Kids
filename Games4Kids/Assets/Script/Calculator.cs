using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    int primeValue, secondValue, tempValue, finalAnswer;
    public Animator AnimatorBack;
    public Texture TextureSum, TextureReduce, TextureDivide, TextureMultiply;
    private string TempoOp;
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(false);
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

        if (TempoOp == "sums") {        GameObject.Find("BackgroundAfter").GetComponent<Renderer>().material.mainTexture = TextureSum; }
        if (TempoOp == "reduces") {     GameObject.Find("BackgroundAfter").GetComponent<Renderer>().material.mainTexture = TextureReduce; }
        if (TempoOp == "divides") {     GameObject.Find("BackgroundAfter").GetComponent<Renderer>().material.mainTexture = TextureDivide; }
        if (TempoOp == "multiples") {   GameObject.Find("BackgroundAfter").GetComponent<Renderer>().material.mainTexture = TextureMultiply; }

        Canvas.SetActive(true);
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
