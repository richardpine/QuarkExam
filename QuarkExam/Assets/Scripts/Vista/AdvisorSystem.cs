using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvisorSystem : MonoBehaviour
{
    static Text advisor;
    static Text information;
    private void Start()
    {
        advisor = GameObject.Find("Advisor").GetComponent<Text>();
        information = GameObject.Find("Information").GetComponent<Text>();
    }
    public static void StockControl()
    {
        ActivateAdvisor();
        advisor.text = "No hay suficiente stock";
    }

    public static void OverZero()
    {
        ActivateAdvisor();
        advisor.text = "Ingrese valores mayores a cero";
    }
    public static void WrongParameter()
    {
        ActivateAdvisor();
        advisor.text = "Valor incorrecto";
    }

    public static void ActivateAdvisor()
    {
        advisor.enabled = true;
    }

    public static void UnActiveAdvisor()
    {
        AdvisorSystem.ClearAdvise();
        advisor.enabled = false;
    }
    public static void OK()
    {
        ActivateAdvisor();
        advisor.text = "Todo esta bien";
    }
    public static void ShowData(float finalPrice)
    {
        ActivateDataText();
        information.text = $"El precio total es de : {finalPrice}";
    }

    public static void InputClothe()
    {
        
        ActivateAdvisor();
        advisor.text = "Debe ingresar un tipo de prenda";
    }

    public static void ActivateDataText()
    {
        information.enabled = true;
    }
    public static void UnActivateDataText()
    {
        AdvisorSystem.ClearData();
        information.enabled = false;
    }

    public static void ClearAdvise()
    {
        advisor.text = "";
    }
    public static void ClearData()
    {
        information.text = "";
    }

    public static void InputQuality()
    {
        ActivateAdvisor();
        advisor.text = "Debe ingresar una calidad";
    }
}
