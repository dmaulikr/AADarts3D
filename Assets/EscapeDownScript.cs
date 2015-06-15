using UnityEngine;
using System.Collections;

public class EscapeDownScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
				


	}
	
	// Update is called once per frame
	void pdate () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Debug.Log ("Escape pressed.");
			Application.Quit();

		}
	}
}
