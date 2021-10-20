using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camisa : Prenda
{
    
    public Sleev TshirtSleeve { private set; get; }
    public Neck TshirtNeck { private set; get; }
    public float Price { get => price; set => price = value; }
    public Quality ClotheQuality { get => clotheQuality; set => clotheQuality = value; }
    public int Stock { get => stock; set => stock = value; }

    public Camisa(int stock, Quality quality, Sleev sleev, Neck neck)
    {
        Stock = stock;
        ClotheQuality = quality;
        TshirtSleeve = sleev;
        TshirtNeck = neck;
    }
    public Camisa(Quality quality, Sleev sleev, Neck neck, float price) // Tambien se pudo poner Stock como opcional: int stock = 0 
    {
        Price = price;
        ClotheQuality = quality;
        TshirtSleeve = sleev;
        TshirtNeck = neck;

    }
    public override float Calcular(int quantity)
    {
        float finalPrice = Price;
        float sleevModification = (TshirtSleeve == Sleev.SHORT) ? -(Price * 10 / 100) : (0);
        float neckModification = (TshirtNeck == Neck.MAO) ? (Price * 3 / 100) : (0);
        float qualityModification = (ClotheQuality == Quality.PREMIUM) ? (Price * 30 / 100) : (0);
        finalPrice += sleevModification + neckModification + qualityModification;
        return finalPrice * quantity;
    }


}
