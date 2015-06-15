using UnityEngine;
using System.Collections;
using System.IO;
public class MouseClickScript : MonoBehaviour {
	public float moveSpeed = 10.0f;
	Material[] mat;
	string[] paths;
	int cnt;
	int c;
	GameObject dynDart;
	void Start(){
//		c = -1;
//		DirectoryInfo dinfo = new DirectoryInfo ("assets/Materials/colors/");
//		
//		float count = dinfo.GetFiles ().Length;
//		count /= 2.0f;
//		cnt = (int) count;
//		paths = new string[cnt];
//		FileInfo[] finfo = dinfo.GetFiles ("*.mat");
//		foreach (FileInfo file in finfo) {
//			c++;
//			paths[c]=@"assets/Materials/colors/"+file.Name;
//			Debug.Log (paths[c]);
//		}


		}
	void Update () {

		if (Input.GetMouseButtonDown(0)) {


			dynDart = (GameObject) Instantiate(GameObject.Find("StaticDart"));
				dynDart.name="DynDart";
				dynDart.AddComponent<SimpleMotion>();
			SimpleMotion sm = dynDart.GetComponent<SimpleMotion>();
			sm.moveSpeed = moveSpeed;
				dynDart.AddComponent<Rigidbody>();
				Rigidbody rb = dynDart.GetComponent<Rigidbody>();
				rb.useGravity=false;

				



			Transform ball = dynDart.transform.FindChild("dart1").FindChild ("group19").FindChild("polySurface18");
			Transform bar = dynDart.transform.FindChild("dart1").FindChild("group19").FindChild("polySurface19");
			ball.gameObject.AddComponent<SphereCollider>();
			bar.gameObject.AddComponent<CapsuleCollider>();
//			int matnr = Random.Range(0,paths.Length);
//			Material mat = (Material) Resources.LoadAssetAtPath<Material>(paths[matnr]);
//			ball.renderer.material = mat;
//			bar.renderer.material = mat;

			}

	}
}
