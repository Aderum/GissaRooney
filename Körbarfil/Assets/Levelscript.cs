using UnityEngine;
using System.Collections;
using UnityEditor;

public class Levelscript : MonoBehaviour {
	public Texture2D bakgrund;
	string profilNamn = "Wayne Rooney";


	void OnGUI () {

	GUI.DrawTexture (new Rect ((Screen.width / 3), 0, Screen.width, Screen.height), bakgrund);
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
	if(GUI.Button(new Rect(((Screen.width/3)*2)-220,(Screen.height/5)*3,200,80), profilNamn)) {

			RättEllerFel(profilNamn);
			//Application.LoadLevel("Level1");
		}

	if(GUI.Button(new Rect(((Screen.width/3)*2)+30,(Screen.height/5)*3,200,80), "Göran Persson")) {
			//Application.LoadLevel("Level1");
		}
	if(GUI.Button(new Rect(((Screen.width/3)*2)-220,(Screen.height/6)*5,200,80), "Usain Bolt")) {
			//Application.LoadLevel("Level1");
		}

		if(GUI.Button(new Rect(((Screen.width/3)*2)+30,(Screen.height/6)*5,200,80), "Anna 4år")) {
			//Application.LoadLevel("Level1");
		}
		
		// Make the second button.
		//GUI.Label(new Rect(0,0,Screen.width/4,Screen.height), testTex);
	}
	private bool RättEllerFel(string Svar){

		if(string.Equals(Svar,profilManager.kändisNamn)){
			
			Application.LoadLevel("VinstSkärm");
			return true;
		}
		return false;
		}
}


// Make a background box
//GUI.backgroundColor = Color.yellow;
//GUI.color = Color.blue;
//GUI.contentColor = Color.green;
//Keyboard.active = true;
//bakgrund = new Texture2D((Screen.width/3),0,Screen.width,Screen.height);
