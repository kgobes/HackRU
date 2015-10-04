using UnityEngine;
using System.Collections;

public class Launch : MonoBehaviour {
	public static GUIText StartText;
	// Use this for initialization
	void Start () {
		StartText = GameObject.Find("Start").GetComponent<GUIText> ();
		StartText.enabled = true;
		StartText.text = "press space to start";

	}


	// Update is called once per frame
	void Update () {
		//StartText.enabled = true;
		//StartText.text = "Press Space to Start";
		if (Input.GetButtonDown ("Start")) {
			Application.LoadLevel(1);
		}
	}
}
