using System.Collections;
using System.Collections.Generic;
using System.Data;
using System;
using UnityEngine;
using Mono.Data.Sqlite;

public class SqliteDB : MonoBehaviour
{
    // Start is called before the first frame update
    private string dbName = "URI=file:Desafios.db";
    void Start()
    {
        /*CreateDB();*/
        ReciveQuery("Select * From sala1");


    }
    // Update is called once per frame
    void Update()
    {
        
    }

	public void CreateDB(){
        using (var connection =new SqliteConnection(dbName)) { 
            connection.Open();
            using (var command = connection.CreateCommand())
            {

            ///creating the tables
                command.CommandText = "" +
                "CREATE TABLE if not exists sala1 (" +
                    "id INTEGER PRIMARY KEY  AUTOINCREMENT ," +
                    "nome varchar(255)," +
                    "idade varchar(255)," +
                    "peso int," +
                    "numero int" +
                    "); ";
            command.ExecuteNonQuery();
            command.CommandText = "" +
                "CREATE TABLE  if not exists sala2 (" +
                    "id INTEGER PRIMARY KEY  AUTOINCREMENT ," +
                    "Nome varchar(255)," +
                    "Aberta bool," +
                    "cor varchar(255)"+
                    "); ";
            command.ExecuteNonQuery();
            command.CommandText = "" +
                "CREATE TABLE  if not exists sala3 (" +
                    "id INTEGER PRIMARY KEY  AUTOINCREMENT ," +
                    "Nome varchar(255)" +
                    "); ";
            command.ExecuteNonQuery();
            command.CommandText = "" +
                "CREATE TABLE  if not exists sala4 (" +
                    "id INTEGER PRIMARY KEY  AUTOINCREMENT ," +
                    "Nome varchar(255) "+
                    "); ";
            command.ExecuteNonQuery();
                //// populating the tables
                ///

            command.CommandText = "" +
            "insert into sala1 (nome,idade,peso,numero) values('Marcelo' ,22,70,1);" +
            "insert into sala1 (nome,idade,peso,numero) values('Julia'   ,23,80,2);" +
            "insert into sala1 (nome,idade,peso,numero) values('Thiago'  ,26,89,3);" +
            "insert into sala1 (nome,idade,peso,numero) values('Rita'    ,23,76,4);" +
            "insert into sala1 (nome,idade,peso,numero) values('João'    ,30,81,5);" +
            "insert into sala1 (nome,idade,peso,numero) values('Matheus' ,27,72,6);" +
            "insert into sala1 (nome,idade,peso,numero) values('Prícila' ,20,76,7);" +
            "insert into sala1 (nome,idade,peso,numero) values('Lucia'   ,32,83,8);" +
            "insert into sala1 (nome,idade,peso,numero) values('Bernardo',24,84,9);" +
            "insert into sala1 (nome,idade,peso,numero) values('Lierson' ,26,74,10);" +
            "insert into sala1 (nome,idade,peso,numero) values('Gabriel' ,20,90,11);" +
            "insert into sala1 (nome,idade,peso,numero) values('......'  ,0 ,0 ,12);";
                command.ExecuteNonQuery();

            command.CommandText = "" +
               "insert into sala2 (nome,aberta,cor) values('Porta de Ferro'     ,false,'Cinza');" +
               "insert into sala2 (nome,aberta,cor) values('Porta de Madeira'   ,false,'Marrom');" +
               "insert into sala2 (nome,aberta,cor) values('Porta de Aço'       ,false,'Cinza');" +
               "insert into sala2 (nome,aberta,cor) values('Porta de Pedra'     ,false,'Cinza');" +
               "insert into sala2 (nome,aberta,cor) values('Porta de Energia'   ,false,'Azul');" +
               "insert into sala2 (nome,aberta,cor) values('Porta de Obsidiana' ,false,'Preta');" +
               "insert into sala2 (nome,aberta,cor) values('Porta de Cristal'   ,false,'Verde');" +
               "insert into sala2 (nome,aberta,cor) values('Porta de Espinhos'  ,false,'Marrom');" +
               "insert into sala2 (nome,aberta,cor) values('Porta do Saida'     ,false,'Vermelha');";
             command.ExecuteNonQuery();

            command.CommandText = "" +
                "insert into sala3 (nome) values('Porta de Saida');" +
                "insert into sala3 (nome) values('Quadra de Basquete');" +
                "insert into sala3 (nome) values('Cesta');";
            command.ExecuteNonQuery();

            command.CommandText = "" +
                "insert into sala4 (nome) values('Leão');" +
            command.ExecuteNonQuery();
            }
        connection.Close();
        }
            

	}
    public void ResetDB()
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DROP TABLE IF EXISTS sala1; ";
                command.ExecuteNonQuery();
                command.CommandText = "DROP TABLE IF EXISTS sala2; ";
                command.ExecuteNonQuery();
                command.CommandText = "DROP TABLE IF EXISTS sala3; ";
                command.ExecuteNonQuery();
                command.CommandText = "DROP TABLE IF EXISTS sala4; ";
                command.ExecuteNonQuery();

                ///creating the tables
                command.CommandText = "" +
                "CREATE TABLE if not exists sala1 (" +
                    "id INTEGER PRIMARY KEY  AUTOINCREMENT ," +
                    "nome varchar(255)," +
                    "idade varchar(255)," +
                    "peso int," +
                    "numero int" +
                    "); ";
                command.ExecuteNonQuery();
                command.CommandText = "" +
                    "CREATE TABLE  if not exists sala2 (" +
                        "id INTEGER PRIMARY KEY  AUTOINCREMENT ," +
                        "Nome varchar(255)," +
                        "Aberta bool," +
                        "cor varchar(255)" +
                        "); ";
                command.ExecuteNonQuery();
                command.CommandText = "" +
                    "CREATE TABLE  if not exists sala3 (" +
                        "id INTEGER PRIMARY KEY  AUTOINCREMENT ," +
                        "Nome varchar(255)" +
                        "); ";
                command.ExecuteNonQuery();
                command.CommandText = "" +
                    "CREATE TABLE  if not exists sala4 (" +
                        "id INTEGER PRIMARY KEY  AUTOINCREMENT ," +
                        "Nome varchar(255) " +
                        "); ";
                command.ExecuteNonQuery();
                //// populating the tables
                ///

                command.CommandText = "" +
                "insert into sala1 (nome,idade,peso,numero) values('Marcelo' ,22,70,1);" +
                "insert into sala1 (nome,idade,peso,numero) values('Julia'   ,23,80,2);" +
                "insert into sala1 (nome,idade,peso,numero) values('Thiago'  ,26,89,3);" +
                "insert into sala1 (nome,idade,peso,numero) values('Rita'    ,23,76,4);" +
                "insert into sala1 (nome,idade,peso,numero) values('João'    ,30,81,5);" +
                "insert into sala1 (nome,idade,peso,numero) values('Matheus' ,27,72,6);" +
                "insert into sala1 (nome,idade,peso,numero) values('Prícila' ,20,76,7);" +
                "insert into sala1 (nome,idade,peso,numero) values('Lucia'   ,32,83,8);" +
                "insert into sala1 (nome,idade,peso,numero) values('Bernardo',24,84,9);" +
                "insert into sala1 (nome,idade,peso,numero) values('Lierson' ,26,74,10);" +
                "insert into sala1 (nome,idade,peso,numero) values('Gabriel' ,20,90,11);" +
                "insert into sala1 (nome,idade,peso,numero) values('......'  ,0 ,0 ,12);";
                command.ExecuteNonQuery();

                command.CommandText = "" +
                   "insert into sala2 (nome,aberta,cor) values('Porta de Ferro'     ,false,'Cinza');" +
                   "insert into sala2 (nome,aberta,cor) values('Porta de Madeira'   ,false,'Marrom');" +
                   "insert into sala2 (nome,aberta,cor) values('Porta de Aço'       ,false,'Cinza');" +
                   "insert into sala2 (nome,aberta,cor) values('Porta de Pedra'     ,false,'Cinza');" +
                   "insert into sala2 (nome,aberta,cor) values('Porta de Energia'   ,false,'Azul');" +
                   "insert into sala2 (nome,aberta,cor) values('Porta de Obsidiana' ,false,'Preta');" +
                   "insert into sala2 (nome,aberta,cor) values('Porta de Cristal'   ,false,'Verde');" +
                   "insert into sala2 (nome,aberta,cor) values('Porta de Espinhos'  ,false,'Marrom');" +
                   "insert into sala2 (nome,aberta,cor) values('Porta do Saida'     ,false,'Vermelha');";
                command.ExecuteNonQuery();

                command.CommandText = "" +
                    "insert into sala3 (nome) values('Porta de Saida');" +
                    "insert into sala3 (nome) values('Quadra de Basquete');" +
                    "insert into sala3 (nome) values('Cesta');";
                command.ExecuteNonQuery();

                command.CommandText = "" +
                    "insert into sala4 (nome) values('Leão');" +
                command.ExecuteNonQuery();
            }
            connection.Close();
        }


    }
    public void ReciveQuery(string query)
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();
            using (var command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = query;
                    Debug.Log( JsonUtility.ToJson( command.ExecuteNonQuery() )  );
                }
                catch(Exception e)
                {
                    print(e);
                }
                

            }
            connection.Close();
        }


    }
}
