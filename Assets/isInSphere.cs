using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class isInSphere : MonoBehaviour {
	int count;
	void Start(){
		count = 0;
		}

	void OnTriggerEnter(Collider c){
		if (PlayerPrefs.HasKey ("gameOver")) {

			if(PlayerPrefs.GetInt("gameOver")==0){
				count++;
			}
				}
		if (PlayerPrefs.GetInt ("gameOver") == 0) {
						int tS = PlayerPrefs.GetInt ("totalScore");
						PlayerPrefs.SetInt ("totalScore", tS + 1);
						Text highscore = GameObject.Find ("Canvas").transform.FindChild ("HighScoreText").GetComponent<Text> ();
						highscore.text = PlayerPrefs.GetInt ("totalScore").ToString ();

						Debug.Log ("Darts: " + count);
						Debug.Log ("Total score: " + PlayerPrefs.GetInt ("totalScore"));
						Text x = GameObject.Find ("Canvas").transform.FindChild ("ScoreTxt").GetComponent<Text> ();
						x.text = count.ToString ();
				}
	}
}
