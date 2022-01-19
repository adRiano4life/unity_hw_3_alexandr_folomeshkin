using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decimalToFloat : MonoBehaviour
{
    [SerializeField] public int number;
    public void DecimalToFloat()
    {
        float floatNumber = Convert.ToSingle(number);
        Debug.Log($"Число {floatNumber} преобразовано в тип float");
    }
}
