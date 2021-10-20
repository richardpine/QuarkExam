using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordControl
{
    //Esta clase deberia volver mas robusto al control de registro y consultas de la base de datos,
    //estaria en la capa de Control de un modelo MVC.

    //Por ejemplo aca se podria hacer un control sobre selección de filtros. Al no integrar toda esa
    //funcionalidad queda sin mucho sentido.

    Record record = new Record();

    List<Cotizacion> budgetList;

    public List<Cotizacion> FromDB()
    {
        budgetList = record.LoadFromBD();
        
        return budgetList;
    }
}
