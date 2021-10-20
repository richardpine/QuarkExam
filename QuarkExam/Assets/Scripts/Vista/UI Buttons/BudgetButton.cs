using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BudgetButton : MonoBehaviour
{
    DropDawnConfiguration dropDawnConfiguration;
    InputFieldConfiguration inputFieldConfiguration;

    public void SendToController()
    {
        dropDawnConfiguration = GameObject.Find("VistaLogic").GetComponent<DropDawnConfiguration>();
        inputFieldConfiguration = GameObject.Find("VistaLogic").GetComponent<InputFieldConfiguration>();
        BudgetController budgetControl = new BudgetController();
        Cotizacion newBudget = budgetControl.Controller(
            dropDawnConfiguration.ValClothe,
            dropDawnConfiguration.ValNeck,
            dropDawnConfiguration.ValSleev,
            dropDawnConfiguration.ValPan,
            dropDawnConfiguration.ValQuality,
            inputFieldConfiguration.Quantity,
            inputFieldConfiguration.Price
            );
        if(newBudget == null)
        {
            AdvisorSystem.StockControl();
        }
        else
        {
            AdvisorSystem.ShowData(newBudget.Total);
            newBudget.SaveBudget();
        }

    }
}
