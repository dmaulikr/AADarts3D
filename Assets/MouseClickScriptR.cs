using UnityEngine;
using System.Collections;
using System.IO;
public class MouseClickScriptR : MonoBehaviour {
	Material[] mat;
	GameObject dynDart;
	string[] paths;
	public float moveSpeed = 10.0f;
	int cnt;
	int c;
	void Start(){

		}
	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			dynDart = (GameObject) Instantiate(GameObject.Find("StaticDart"));

				dynDart.name="DynDart";
				dynDart.AddComponent<SimpleMotionR>();
			SimpleMotionR smr = dynDart.GetComponent<SimpleMotionR>();
			smr.moveSpeed = moveSpeed;
				dynDart.AddComponent<Rigidbody>();
				Rigidbody rb = dynDart.GetComponent<Rigidbody>();
				rb.useGravity=false;

			Transform ball = dynDart.transform.FindChild("dart1").FindChild ("group19").FindChild("polySurface18");
			Transform bar = dynDart.transform.FindChild("dart1").FindChild("group19").FindChild("polySurface19");
			ball.gameObject.AddComponent<SphereCollider>();
			bar.gameObject.AddComponent<CapsuleCollider>();

			}


	}
}
