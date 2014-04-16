using UnityEngine;
using System.Collections;
using System.Data;
using Mono.Data.SqliteClient;

public static class HelpClass : object {

	public static string[,] GetNames (int antal)
	{
		string[,] resultat = new string[antal,2];
		int person = 0;

		string connectionString = "URI=file:"+Application.dataPath+ "/SqliteTest";
		IDbConnection dbcon;
		dbcon = (IDbConnection) new SqliteConnection(connectionString);
		dbcon.Open();
		IDbCommand dbcmd = dbcon.CreateCommand();
		
		
		string sql =
			"SELECT name, picture " +"FROM profil";
		dbcmd.CommandText = sql;
		IDataReader reader = dbcmd.ExecuteReader ();
		while (reader.Read()) {
						resultat [person, 0] = reader.GetString (0);
						resultat [person, 1] = reader.GetString (1);
				}
		reader.Close ();
		reader = null;
		dbcmd.Dispose ();
		dbcmd = null;
		dbcon.Close ();
		dbcon = null;
				//Debug.Log("Name: " + FirstName + " " + LastName);

			
		return resultat;
		}
}
