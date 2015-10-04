using UnityEngine;
using System.Collections;
using Leap;

public class GestureHands : MonoBehaviour {
	Controller controller;
	Frame start;
	public GameObject player;
	
	// Use this for initialization
	void Start () {
		controller = new Controller();
		player = GameObject.Find ("Player");

		controller.Config.Save();
	}
	
	// Update is called once per frame
	void Update () {

		Frame frame = controller.Frame ();

		//GestureList gestures = frame.Gestures();

		//get hand, find axis of rotation and get angle
		Hand hand = frame.Hands[0];
		float pitch = hand.Direction.Pitch;
		float yaw = hand.Direction.Yaw;

//		float pitch = (float) (hand.Direction.Pitch * 0.8);

		//transform.Rotate(Vector3.right, 2*pitch);

		//transform.Rotate(Vector3.forward, -yaw);
//
//
//		float yaw = (float) (hand.Direction.Yaw * 1.5);
//
//		print (pitch);
//		print (yaw);
	}
}
