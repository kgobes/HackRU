using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed = 50.0F;

	// Use this for initialization
	void Start () {
		print ("in start");
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition -= transform.forward * speed * Time.deltaTime;
		if (transform.localPosition.z <= -30) {
			print ("at -10");
			transform.localPosition = new Vector3(0, 0, 0);
		}
}
}
