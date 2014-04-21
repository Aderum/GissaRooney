using UnityEngine;
using System.Collections;

public class Vscript : MonoBehaviour {

	// Use this for initialization
	void OnGUI(){

		if(GUI.Button(new Rect((Screen.width/4)*3,(Screen.height/4)*3,100,100),"Nästa Level")){
			Application.LoadLevel("Level1");
			profilManager.t++;


		}
	}
}
