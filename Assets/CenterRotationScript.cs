using UnityEngine;
using System.Collections;

public class CenterRotationScript : MonoBehaviour {
	public float AngularSpeed = 30.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (transform.position, Vector3.forward, Time.deltaTime * AngularSpeed);
	}
}
