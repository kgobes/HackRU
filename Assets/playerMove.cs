using UnityEngine;
using System.Collections;
using Leap;

public class playerMove : MonoBehaviour {
	public float speed = 20.0f;
	private Vector3 moveDirection = Vector3.zero;

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


		//CharacterController controller= GetComponent <CharacterController>();
		//transform.Translate(Input.GetAxis ("Horizontal") *Time.deltaTime, Input.GetAxis ("Vertical") *Time.deltaTime, 0f);
		if (yaw >= Mathf.PI || pitch >= Mathf.PI) {
			yaw = 0.0f;
			pitch = 0.0f;
		}

		transform.Translate(yaw *Time.deltaTime*10, pitch *Time.deltaTime* 10, 0f);
	}

	void OnTriggerEnter(Collider other){
		print ("collision");
		//if(other.gameObject.name == "Spawn")
			//Destroy (other.gameObject);
	}
}