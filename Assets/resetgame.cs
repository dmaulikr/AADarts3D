using UnityEngine;
using System.Collections;

public class resetgame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			Debug.Log ("Resetted");
			PlayerPrefs.SetInt("LevelNr",0);
			PlayerPrefs.SetInt("totalScore",0);
			Application.Quit();
				}
	}
}
