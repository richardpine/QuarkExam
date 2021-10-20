using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pantalon : Prenda
{
    public float Price { get => price; set => price = value; }
    public Quality ClotheQuality { get => clotheQuality; set => clotheQuality = value; }
    public int Stock { get => stock; set => stock = value; }

    public Pant PantType { set; get; }

    public Pantalon(int stock, Quality quality, Pant pantType)
    {
        Stock = stock;
        ClotheQuality = quality;
        PantType = pantType;
    }
    public Pantalon(Quality quality, Pant pantType, float price)
    {
        this.ClotheQuality = quality;
        this.PantType = pantType;
        this.Price = price;
    }
    public override float Calcular(int quantity)
    {
        float finalPrice = Price;
        float neckModification = (PantType == Pant.CHUPIN) ? -(Price * 12 / 100) : (0);
        float qualityModification = (ClotheQuality == Quality.PREMIUM) ? (Price * 30 / 100) : (0);
        finalPrice += neckModification + qualityModification;
        return finalPrice * quantity;
    }
}
