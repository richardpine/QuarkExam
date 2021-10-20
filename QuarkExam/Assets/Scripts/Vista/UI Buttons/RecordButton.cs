using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordButton : MonoBehaviour
{
    RecordControl rc = new RecordControl();
    [SerializeField] GameObject prefab;
    [SerializeField] GameObject parent;

    public void ListarRegistro()
    {
        ClearList();
        List<Cotizacion> list = rc.FromDB();
        foreach(Cotizacion c in list)
        {
            GameObject detailBudgetItem;
            detailBudgetItem = Instantiate(prefab, parent.transform);
            Text[] texts = new Text[detailBudgetItem.GetComponentsInChildren<Text>().Length];
            texts = detailBudgetItem.GetComponentsInChildren<Text>();
            texts[0].text = $"{c.Id}";
            texts[1].text = $"{c.CurrentDateTime}";
            texts[2].text = $"{c.SellerCode}";
            texts[3].text = $"{c.Clothe}";
            texts[4].text = $"{c.Quantity.ToString()}";
            texts[5].text = $"{c.Total.ToString()}";
        }
    }

    private void ClearList()
    {
        GameObject[] listItem = GameObject.FindGameObjectsWithTag("ItemBudget");
        if(listItem.Length != 0)
        {
            foreach(GameObject g in listItem)
            {
                Destroy(g);
            }
        }
    }
}
