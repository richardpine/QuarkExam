using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda
{
    public string Name { private set; get; }
    public string Address { private set; get; }
    public ArrayList ClothesList { private set; get; }

    public Vendedor Seller { private set; get; }
    public Tienda(string name, string address, ArrayList list, Vendedor newSeller)
    {
        Name = name;
        Address = address;
        ClothesList = list;
        Seller = newSeller;
    }
}
