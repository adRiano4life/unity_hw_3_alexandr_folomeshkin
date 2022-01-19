using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleToDecimal : MonoBehaviour
{
    [SerializeField] public double number;
    public void DoubleToDecimal()
    {
        decimal decNumber = Convert.ToDecimal(number);
        Debug.Log($"Число {decNumber} преобразовано в тип decimal");
    }
}
