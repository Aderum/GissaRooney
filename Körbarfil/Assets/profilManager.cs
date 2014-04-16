using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Data;
using Mono.Data.SqliteClient;

public class profilManager : MonoBehaviour {
	
	Texture2D profil;
	public Camera camera;
	public static string kändisNamn;

	void Start()
	{

		string[,] resutat = HelpClass.GetNames (1);
		transform.position = new Vector2 (camera.ScreenToWorldPoint (new Vector3 (Screen.width / 6, 0, 0)).x, camera.ScreenToWorldPoint (new Vector3 (0, Screen.height/2, 0)).y);
		transform.localScale = new Vector3 (1.3f, 2, 1);

		profil = AssetDatabase.LoadAssetAtPath("Assets/Bilder/"+resutat [0, 1],typeof(Texture2D)) as Texture2D;
				Sprite sprite = new Sprite();
				sprite = Sprite.Create(profil,new Rect(0,0,profil.width,profil.height),new Vector2(0.5f,0.5f),100f);
				this.GetComponent<SpriteRenderer>().sprite=sprite;
		Debug.Log (resutat [0, 0] + resutat [0, 1]);

				kändisNamn = resutat[0,0];



	}



}
