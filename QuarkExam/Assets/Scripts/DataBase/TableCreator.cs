using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableCreator : MonoBehaviour
{
    public class Cols
    {
        public string nameCols = "";
        public string type = "";
        public bool allowNull;
        public bool isKey;
        public string cadena;
    }
    [SerializeField] string nameTable="";
    [SerializeField] List<Cols> myCols = new List<Cols>();
    enum typeOfAttribute {VARCHAR,INTEGER,};
    [SerializeField] typeOfAttribute thisType;
    
    [SerializeField] List<string> nameCols = new List<string>();
    string consulta ="(";
    // Start is called before the first frame update
    void Start()
    {
        
        string temp = thisType.ToString();
        Debug.Log(temp);
        CrearColumna();
        CrearTabla();
    }

    public void CrearColumna()
    {
        foreach (string q in nameCols)
        {
            if (nameCols.IndexOf(q) == nameCols.Count - 1)
            {
                consulta += $" {q})";
            }
            else
            {
                consulta += $" {q},";
            }
        }
        
        
    }
    public void CrearTabla()
    {
        string table = $"CREATE TABLE IF NOT EXIST {nameTable}";
        table += consulta;
        Debug.Log(table);
    }
}
