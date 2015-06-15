using UnityEngine;
using System.Collections;

public class ReversedROTScript : MonoBehaviour {
	public float AngularSpeed = 30.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (transform.position, Vector3.back, Time.deltaTime * AngularSpeed);
	}
}
