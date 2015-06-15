using UnityEngine;
using System.Collections;

public class ReversedSimpleRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SimpleMotionR sm = gameObject.GetComponent<SimpleMotionR> ();
		GameObject.Destroy (sm);
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (transform.position, Vector3.back, 40 * Time.deltaTime);

	}
}
