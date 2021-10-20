using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Prenda
{
    public abstract int Stock { set; get; }
    public abstract float Price { set; get; }
    public abstract Quality ClotheQuality { set; get; }

    public abstract float Calcular(int quantity);


}
