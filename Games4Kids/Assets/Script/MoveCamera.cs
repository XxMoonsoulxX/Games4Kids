using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public void MoveTheCamera()
    {
        Calculator Temporal = GameObject.Find("Calculator").GetComponent<Calculator>();
        Temporal.AmoveCamera();
    }
}
