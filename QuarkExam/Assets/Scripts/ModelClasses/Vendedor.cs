using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendedor
{
    public string Name { private set; get; }
    public string LastName { private set; get; }
    public int SellerCode { private set; get; }

    public Vendedor(string name, string lastName, int sellerCode)
    {
        Name = name;
        LastName = lastName;
        SellerCode = sellerCode;
    }
}
