using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

public class Connection : MonoBehaviour
{
    //[SerializeField] string serverName, dataBaseName, user, password;
    public string DataBaseName { get; set; } = "QuarkClotheShop";
    
    public static Connection instance;
    
    private string dbLocation;
    
    private void Awake()
    {
        dbLocation = $"URI=file:{DataBaseName}.db";
        instance = this; // No me convence usar singleton para la clase que maneja la base de datos
    }
    void Start()
    {
        CreateTable();
    }

    private void CreateTable()
    {
        // Creamos la clase para almacenar la conexion y la Inicializamos
        // con la ubicación de la base de datos.

        SqliteConnection connection = new SqliteConnection(dbLocation);

        // Abrimos La Conexión.
        connection.Open();

        // Creamos una clase comando.
        SqliteCommand newCommand = connection.CreateCommand();

        // Creamos un string y dentro le concatenamos la consulta
        string sqlcreation = "";

        sqlcreation += "CREATE TABLE IF NOT EXISTS cotizacion(";
        sqlcreation += "Id INTEGER NOT NULL ";
        sqlcreation += "PRIMARY KEY AUTOINCREMENT,";
        sqlcreation += "Date     VARCHAR(50) NOT NULL,"; 
        sqlcreation += "SellerId     INTEGER NOT NULL,";
        sqlcreation += "ClotheDescription     VARCHAR(50) NOT NULL,";
        sqlcreation += "Quantity     INTEGER NOT NULL,";
        sqlcreation += "TotalPrice FLOAT NOT NULL";
        sqlcreation += ");";
        // Dentro del objeto del tipo SqliteCommand accedemos al campo de texto
        // del comando y le asignamos la consulta creada en el string.
        newCommand.CommandText = sqlcreation;
        // Ejecutamos la consulta
        newCommand.ExecuteNonQuery();
        // Cerramos la Conexión.
        connection.Close();
    }

    public List<Cotizacion> Query(string queue)
    {

        SqliteConnection connection = new SqliteConnection(dbLocation);
            
        connection.Open();

        SqliteCommand command = connection.CreateCommand();
            
        command.CommandText = queue;

        SqliteDataReader reader = command.ExecuteReader();

        List<Cotizacion> budgetList = new List<Cotizacion>();
        while (reader.Read())
        {
            budgetList.Add(new Cotizacion(
                                int.Parse(reader["Id"].ToString()),
                                reader["Date"].ToString(),
                                int.Parse(reader["SellerId"].ToString()),
                                reader["ClotheDescription"].ToString(),
                                int.Parse(reader["Quantity"].ToString()),
                                float.Parse(reader["TotalPrice"].ToString())
                                )
                           );
        }      
        connection.Close();
        return budgetList;
    }
}

