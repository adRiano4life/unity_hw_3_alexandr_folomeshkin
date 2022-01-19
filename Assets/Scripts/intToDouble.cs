using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intToDouble : MonoBehaviour
{
    [SerializeField] public int number;

    public void IntToDoubleFunc()
    {
        double doubleNumber = Convert.ToDouble(number);
        Debug.Log($"Число {doubleNumber} преобразовано в тип double");
    }
}
