﻿using UnityEngine;
using System.Collections;
using UnityEditor;

public class Levelscript : MonoBehaviour {
	public Texture2D bakgrund;
	public Texture2D Options;
	GameObject other;
	bool test = false;
	public GUISkin skin,skin2;

	void OnGUI () {

		GUI.skin = skin;
	GUI.DrawTexture (new Rect ((Screen.width / 3), 0, Screen.width, Screen.height), bakgrund);
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if(GUI.Button(new Rect(((Screen.width/3)*2)-220,(Screen.height/5)*3,200,80), profilManager.Svar1)) {

			RättEllerFel(profilManager.Svar1);
			//Application.LoadLevel("Level1");
		}

	if(GUI.Button(new Rect(((Screen.width/3)*2)+30,(Screen.height/5)*3,200,80), profilManager.Svar2)) {
			RättEllerFel(profilManager.Svar2);
			//Application.LoadLevel("Level1");
		}
	if(GUI.Button(new Rect(((Screen.width/3)*2)-220,(Screen.height/6)*5,200,80), profilManager.Svar3)) {
			RättEllerFel(profilManager.Svar3);
			//Application.LoadLevel("Level1");
		}

		if(GUI.Button(new Rect(((Screen.width/3)*2)+30,(Screen.height/6)*5,200,80), profilManager.Svar4)) {
			RättEllerFel(profilManager.Svar4);
			//Application.LoadLevel("Level1");
		}
		if (test) {
			GUI.Label(new Rect((Screen.width/3)*2 -100,Screen.height/5,200,200), profilManager.rättSvar);
		}
		GUI.skin = skin2;
		if(GUI.Button(new Rect((Screen.width/10) * 9,Screen.height/100,100,100),Options)){
			//if(GUI.Button(new Rect(250,100,100,100),Options)){	
			Application.LoadLevel("Inställningar");
		}
		
		// Make the second button.
		//GUI.Label(new Rect(0,0,Screen.width/4,Screen.height), testTex);
	}
	private bool RättEllerFel(string Svar){

		if(string.Equals(Svar,profilManager.rättSvar)){
			test = true;
			Application.LoadLevel("VinstSkärm");
			return true;
		}
	//skin.button.
		//skin.button.normal.background = AssetDatabase.LoadAssetAtPath("Assets/Bilder/"+"Wayne.jpg",typeof(Texture2D)) as Texture2D;
		return false;
		}

}


// Make a background box
//GUI.backgroundColor = Color.yellow;
//GUI.color = Color.blue;
//GUI.contentColor = Color.green;
//Keyboard.active = true;
//bakgrund = new Texture2D((Screen.width/3),0,Screen.width,Screen.height);
