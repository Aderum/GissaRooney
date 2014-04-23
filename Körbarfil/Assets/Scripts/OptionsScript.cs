using UnityEngine;
using System.Collections;

public class OptionsScript : MonoBehaviour {
	public GUISkin skin;
	public Texture2D bakgrund;
	void OnGUI(){

		GUI.DrawTexture (new Rect(0, 0, Screen.width, Screen.height), bakgrund);
		GUI.skin = skin;
		if(GUI.Button(new Rect(Screen.width/2.5f,250,200,70), "Ändra textstorlek")) {
			skin.button.fontSize = 20;
		}
		
		if(GUI.Button(new Rect(Screen.width/2.5f,350,200,70), "Spela")) {
			Application.LoadLevel("Level1");
		}
}
}
