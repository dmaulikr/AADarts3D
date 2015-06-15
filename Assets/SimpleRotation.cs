using UnityEngine;
using System.Collections;

public class SimpleRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SimpleMotion sm = gameObject.GetComponent<SimpleMotion> ();
		GameObject.Destroy (sm);
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (transform.position, Vector3.forward, 40 * Time.deltaTime);

	}
}
