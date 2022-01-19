using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class homework3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 9;
        double d = 10.4;
        decimal dec = 3.7m;
        float f = 4.7f;

        int dInt = Convert.ToInt16(d);
        double decDouble = Convert.ToDouble(dec);
        decimal fDec = Convert.ToDecimal(f);
        double iDouble = Convert.ToDouble(i);

        string all = $"int = {i},\n" +
                     $"int в double = {iDouble},\n" +
                     $"double = {d},\n" +
                     $"double в int = {dInt},\n" +
                     $"decimal = {dec},\n" +
                     $"decimal в double = {decDouble},\n" +
                     $"float = {f},\n" +
                     $"float в decimal = {fDec}";
        
        Debug.Log($"Число типа int = {i}");
        Debug.Log($"Число типа double = {d}");
        Debug.Log($"Число типа decimal = {dec}");
        Debug.Log($"Число типа float = {f}");
        
        Debug.LogWarning($"Преобразование double в int = {dInt}");
        Debug.LogWarning($"Преобразование decimal в double = {decDouble}");
        Debug.LogWarning($"Преобразование float в decimal = {fDec}");
        Debug.LogWarning($"Преобразование int в double = {iDouble}");
        
        Debug.Log(all);

        string path = @"E:\Unity\3\classwork\homework\unity_homework_3_alexandr_folomeshkin\text.txt"; //Путь изменить на свой
        using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
        {
            sw.WriteLine(all);
            Debug.Log("Переменные записаны в текстовый файл");
        }

    }
}
