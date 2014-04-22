using UnityEngine;
using System.Collections;
using System;
using System.Data;
using Mono.Data.SqliteClient;

public class Sql : MonoBehaviour {

	int test = 0;
	void Start()
	{
		string connectionString = "URI=file:"+Application.dataPath+ "/SqliteTest";
		IDbConnection dbcon;
		dbcon = (IDbConnection) new SqliteConnection(connectionString);
		dbcon.Open();
		IDbCommand dbcmd = dbcon.CreateCommand();


		string sql =
			"SELECT name, picture " +"FROM profil";
		dbcmd.CommandText = sql;
		IDataReader reader = dbcmd.ExecuteReader();
		while(reader.Read()) {
		if(test == 0){
			string FirstName = reader.GetString (0);
			string LastName = reader.GetString (1);
			Debug.Log("Name: " + FirstName + " " + LastName);
			}
			test++;
			          }
			          // clean up
		reader.Close();
		reader = null;
		dbcmd.Dispose();
		dbcmd = null;
		dbcon.Close();
		dbcon = null;
	}
}

