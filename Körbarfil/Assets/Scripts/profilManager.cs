using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Data;
using Mono.Data.SqliteClient;

public class profilManager : MonoBehaviour {
	
	Texture2D profil;
	public Camera camera;
	public static string Svar1,Svar2,Svar3,Svar4,rättSvar,nextLvl;
	public static int t = 0;

	void Start()
	{
		string[,] resutat = HelpClass.GetNames (4);
		nextLvl = resutat [t, 1];
		rättSvar = resutat [t,0];


		transform.position = new Vector2 (camera.ScreenToWorldPoint (new Vector3 (Screen.width / 6, 0, 0)).x, camera.ScreenToWorldPoint (new Vector3 (0, Screen.height/2, 0)).y);
		transform.localScale = new Vector3 (1.3f, 2, 1);

		profil = AssetDatabase.LoadAssetAtPath("Assets/Bilder/"+nextLvl,typeof(Texture2D)) as Texture2D;
				Sprite sprite = new Sprite();
				sprite = Sprite.Create(profil,new Rect(0,0,profil.width,profil.height),new Vector2(0.5f,0.5f),100f);
				this.GetComponent<SpriteRenderer>().sprite=sprite;
		Debug.Log (resutat [0, 0] + resutat [0, 1]);
		//ArrayList random = new ArrayList (resutat);
		
		for (int i = 0; i<4; i++) {
			string temp = resutat[i,0];
			int r = Random.Range(0,4);
			Debug.Log(r);
			resutat[i,0] = resutat[r,0];
			resutat[r,0] = temp;
			
		}
				Svar1 = resutat[0,0];
				Svar2 = resutat [1, 0];
				Svar3 = resutat [2, 0];
				Svar4 = resutat [3, 0];


	}



}
