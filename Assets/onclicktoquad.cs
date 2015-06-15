using UnityEngine;
using System.Collections;

public class onclicktoquad : MonoBehaviour {

	void OnMouseDown(){
		if (PlayerPrefs.HasKey ("LevelNr")) {
						int s = PlayerPrefs.GetInt ("LevelNr");
						s++;
						PlayerPrefs.SetInt ("LevelNr", s);
						if (s % 2 == 0) {
								Application.LoadLevel ("darts2");

						} else {
								Application.LoadLevel ("reversedRotation");
						}
				} else {
						Application.LoadLevel ("darts2");
				}
	}
}
