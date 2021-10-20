using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputFieldConfiguration : MonoBehaviour
{
    [SerializeField] TMP_InputField inputPrice;
    [SerializeField] TMP_InputField inputQuantity;

    [SerializeField] Button budgetButton;

    public float Price { private set; get; }
    public int Quantity { private set; get; }

    public void UnActiveInputs()
    {
        inputPrice.text = "";
        inputQuantity.text = "";
        inputPrice.interactable = false;
        inputQuantity.interactable = false;
        budgetButton.interactable = false;
    }
    public void ActivarInputPrice()
    {        
        inputPrice.interactable = true;
        inputPrice.contentType = TMP_InputField.ContentType.DecimalNumber;
    }
    public void ActivarInputQuantity(string var)
    {
        
        if (var != "")
        {
            float tempVar;
            try
            {
                tempVar = float.Parse(var);
                if (tempVar > 0)
                {
                    AdvisorSystem.UnActiveAdvisor();
                    inputQuantity.interactable = true;
                    inputQuantity.contentType = TMP_InputField.ContentType.DecimalNumber;
                    Price = tempVar;
                }
                else
                {
                   
                    AdvisorSystem.OverZero();
                }
            }
            catch
            {
                AdvisorSystem.WrongParameter();
            }
        }
        else
        {
            inputQuantity.interactable = false;
        }
    }
    public void ActivarBoton(string var)
    {
        if (var != "")
        {
            int tempVar;
            try
            {
                tempVar = int.Parse(var);
                if (tempVar > 0)
                {
                    AdvisorSystem.UnActiveAdvisor();
                    budgetButton.interactable = true;
                    Quantity = tempVar;
                }
                else
                {
                    
                    AdvisorSystem.OverZero();
                }
            }
            catch
            {
                AdvisorSystem.WrongParameter();
            }
        }
        else
        {
            budgetButton.interactable = false;
        }
       
    }
    

    
}
