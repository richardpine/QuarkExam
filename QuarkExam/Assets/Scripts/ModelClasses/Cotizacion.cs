using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Cotizacion : IPrintable
{
    public int Id { private set; get; }
    public string CurrentDateTime { private set; get; }
    public int SellerCode { private set; get; }
    public string Clothe { private set; get; }
    public int Quantity { private set; get; }
    public float Total { private set; get; }

    public Cotizacion()
    {

    }
    public Cotizacion(int sellerId, string clotheDescription, int quantity, float total)
    {
        
        this.SellerCode = sellerId;
        this.Clothe = clotheDescription;
        this.Quantity = quantity;
        this.Total = total;

        CalculateCurrentTime();
    }

    private void CalculateCurrentTime()
    {
        this.CurrentDateTime = DateTime.Now.ToString();
        Debug.Log(CurrentDateTime);
    }

    public Cotizacion(int id, string date, int sellerCode, string clotheDesc, int quantity, float totalPrice)
    {
        Id = id;
        CurrentDateTime = date;
        SellerCode = sellerCode;
        Clothe = clotheDesc;
        Quantity = quantity;
        Total = totalPrice;
    }

    public void SaveBudget()
    {
        string query = "";

        query += "INSERT INTO cotizacion ";
        query += "(Date, SellerId, ClotheDescription, Quantity, TotalPrice) ";
        query += $"VALUES ('{this.CurrentDateTime}','{this.SellerCode}','{this.Clothe}','{this.Quantity}','{this.Total}');";
        Connection.instance.Query(query);
    }

    public void Print()
    {

    }
}
