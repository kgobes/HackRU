using UnityEngine;
using System.Collections;
using Leap;

public class GestureHands : MonoBehaviour {
	Controller controller;
	Frame start;
	
	// Use this for initialization
	void Start () {
		controller = new Controller();

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

		print (pitch);
		print (yaw);
	}
}
