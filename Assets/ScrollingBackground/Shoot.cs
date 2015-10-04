using UnityEngine;
using System.Collections;
using Leap;

public class Shoot : MonoBehaviour {
	Controller controller;
	public GameObject player;
	// Use this for initialization
	void Start () {

		player = GameObject.Find ("Player");

		controller = new Controller();
		controller.EnableGesture (Gesture.GestureType.TYPE_CIRCLE);
		controller.EnableGesture (Gesture.GestureType.TYPE_KEY_TAP);
		controller.EnableGesture (Gesture.GestureType.TYPE_SCREEN_TAP);
		controller.EnableGesture (Gesture.GestureType.TYPE_SWIPE);
		controller.EnableGesture (Gesture.GestureType.TYPE_INVALID);
		controller.Config.SetFloat ("Gesture.Swipe.MinLength", 200.0f);
		controller.Config.SetFloat ("Gesture.Swipe.MinVelocity", 750f);
		
		controller.Config.Save();


	
	}
	
	// Update is called once per frame
	void Update () {

		
		Frame frame = controller.Frame();
		GestureList gestures = frame.Gestures();
		
		for (int i=0; i < gestures.Count; i++) {
			Gesture gesture = gestures[i];
			if(gesture.Type == Gesture.GestureType.TYPE_CIRCLE){
				KeyTapGesture key = new KeyTapGesture(gesture);

					//do barrel roll
					player.transform.Rotate(Vector3.forward, 10);
					print("circle");
	
			}
			if(gesture.Type == Gesture.GestureType.TYPE_KEY_TAP){
				KeyTapGesture key = new KeyTapGesture(gesture);
				
				//do barrel roll
				//player.transform.Rotate(Vector3.forward, 10);
				print("keytap");
				
			}
			if(gesture.Type == Gesture.GestureType.TYPE_SCREEN_TAP){
				KeyTapGesture key = new KeyTapGesture(gesture);
				
				//do barrel roll
				//player.transform.Rotate(Vector3.forward, 10);
				print("screen");
				
			}
			if(gesture.Type == Gesture.GestureType.TYPE_SWIPE){
				KeyTapGesture key = new KeyTapGesture(gesture);
				
				//do barrel roll
				//player.transform.Rotate(Vector3.forward, 10);
				print("swipe");
				
			}
			if(gesture.Type == Gesture.GestureType.TYPE_INVALID){
				KeyTapGesture key = new KeyTapGesture(gesture);
				
				//do barrel roll
				//player.transform.Rotate(Vector3.forward, 10);
				print("invalid");
				
			}
			
		}
	
	}
}
