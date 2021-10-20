using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BudgetController
{
    SetInitialValues initialValues;

    public BudgetController() { }
    private int stock;
    public Cotizacion Controller(int typeClothe, Neck neck, Sleev sleev, Pant pant, Quality quality, int quantity, float price)
    {
        initialValues = GameObject.Find("Installer").GetComponent<SetInitialValues>();
        Cotizacion newBudget;
        float totalPrice = 0;
        string tempClotheDesc = "";
        switch(typeClothe)
        {
            case 1:
                {
                   if(CheckStock(neck, sleev, quality) >= quantity)
                    {
                        //Debug.Log("Hay Stock");
                        tempClotheDesc = $"Camisa, Manga:{sleev}, Cuello:{neck}";
                        totalPrice = new Camisa(quality, sleev,neck,price).Calcular(quantity);

                        newBudget = new Cotizacion(initialValues.seller.SellerCode, tempClotheDesc,quantity, totalPrice);
                        
                        return newBudget;
                    }
                    else
                    {
                        //Debug.Log("No hay Stock");
                        return null;
                    }
                }
            case 2:
                {
                    if (CheckStock(pant, quality) >= quantity)
                    {
                        tempClotheDesc = $"Pantalon, Tipo:{pant}";
                        totalPrice = new Pantalon(quality,pant, price).Calcular(quantity);
                        newBudget = new Cotizacion(initialValues.seller.SellerCode, tempClotheDesc, quantity, totalPrice);
                        return newBudget;

                    }
                    else
                    {
                        return null;
                    }
                }
            default:
                {
                    return null;
                }
        }
    }

    private int CheckStock(Neck neck, Sleev sleev, Quality quality)
    {
        
        int stock = 0;
        foreach (var p in initialValues.miTienda.ClothesList)
        {
            
            if (p.GetType().ToString() == "Camisa")
            {
                Camisa tempCamisa = (Camisa)p;
                if (tempCamisa.ClotheQuality == quality && tempCamisa.TshirtNeck == neck && tempCamisa.TshirtSleeve == sleev)
                {
                    

                    stock = tempCamisa.Stock;
                }
            }
        }
        return stock;

    }
    private int CheckStock(Pant pant, Quality quality)
    {
        int stock = 0;
        foreach (var p in initialValues.miTienda.ClothesList)
        {
            if (p.GetType().ToString() == "Pantalon")
            {
                Pantalon tempPantalon = (Pantalon)p;
                if (tempPantalon.ClotheQuality == quality && tempPantalon.PantType == pant)
                {
                    stock = tempPantalon.Stock;
                }
            }
        }
        return stock;

    }
}
