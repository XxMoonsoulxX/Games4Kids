using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMultiply : MonoBehaviour
{
    private void OnMouseDown()
    {
        Calculator VarTemporal = GameObject.Find("Calculator").GetComponent<Calculator>();
        VarTemporal.FunctionMultiply();
    }
}
