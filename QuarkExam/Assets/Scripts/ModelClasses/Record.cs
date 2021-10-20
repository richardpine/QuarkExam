using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record : IPrintable
{
    private List<Cotizacion> budgetsList;

    public Record(List<Cotizacion> list)
    {
        budgetsList = list;
    }
    public Record()
    {
        budgetsList = new List<Cotizacion>();
    }

    public List<Cotizacion> LoadFromBD()
    {
        budgetsList = Connection.instance.Query("SELECT * FROM cotizacion;");
        return budgetsList;
    }

    public void Print()
    {
        
    }
}
