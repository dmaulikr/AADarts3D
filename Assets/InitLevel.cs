using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class InitLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (!PlayerPrefs.HasKey ("LevelNr")) {
						PlayerPrefs.SetInt ("LevelNr", 0);
				} else {
			Debug.Log ("Level number: " + PlayerPrefs.GetInt("LevelNr"));
				}
		if (PlayerPrefs.HasKey ("totalScore")) {
			Text totalScore = GameObject.Find("Canvas").transform.FindChild("HighScoreText").GetComponent<Text>();
			totalScore.text = PlayerPrefs.GetInt("totalScore").ToString();
				}
		PlayerPrefs.SetInt ("gameOver", 0);
		Debug.Log (Application.loadedLevelName.ToString ());
	}
}
