using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Prenda
{
    protected int stock;
    protected float price;
    protected Quality clotheQuality;

    

    public abstract float Calcular(int quantity);


}
