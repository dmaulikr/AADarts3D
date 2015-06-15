using UnityEngine;
using System.Collections;

public class ColDetect : MonoBehaviour {
	void OnCollisionEnter(Collision collision) {

		GameObject g = GameObject.Find ("Quad");
		g.transform.position = new Vector3 (4.901f,-1.03f,-1.12f);
		PlayerPrefs.SetInt ("gameOver", 1);

		//Application.LoaLevel ("GameOver");


			}
		
}
