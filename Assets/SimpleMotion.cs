using UnityEngine;
using System.Collections;

public class SimpleMotion : MonoBehaviour {
	GameObject sph;
	public float moveSpeed = 10.0f;
	void Start(){
		sph = GameObject.Find("CenterSphere");
		}
	void Update () {
		transform.Translate (Vector3.left * moveSpeed * Time.deltaTime);
		if (transform.position.x <= sph.transform.position.x) {
			transform.position = sph.transform.position;
			gameObject.AddComponent<SimpleRotation>();

				}
	}
}
