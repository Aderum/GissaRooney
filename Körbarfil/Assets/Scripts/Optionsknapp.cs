using UnityEngine;
using System.Collections;

public class Optionsknapp : MonoBehaviour {

	public GUISkin skin;
	public Texture2D Options;
	void OnGUI () {
		GUI.skin = skin;
		//GUILayer = 

//		if(GUI.Button(new Rect((Screen.width/10) * 9,Screen.height/100,100,100),Options)){
//		//if(GUI.Button(new Rect(250,100,100,100),Options)){	
//			Application.LoadLevel("Inställningar");
		//}
	}
}
//}
