using UnityEngine;
using System.Collections;

public class Startskärm : MonoBehaviour {
	public GUISkin skin;

	void OnGUI () {
		GUI.skin = skin;
		// Make a background box
		//GUI.backgroundColor = Color.yellow;
		//GUI.color = Color.blue;
		//GUI.contentColor = Color.green;
		//Keyboard.active = true;
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(Screen.width/2.5f,250,200,70), "Spela")) {
			Application.LoadLevel("Level1");
		}
		
		if(GUI.Button(new Rect(Screen.width/2.5f,350,200,70), "Inställningar")) {
			Application.LoadLevel("Inställningar");
		}
		
		// Make the second button.
		//GUI.Label(new Rect(0,0,Screen.width/4,Screen.height), testTex);
	}
}
