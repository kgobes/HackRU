using UnityEngine;
using System.Collections;
using Leap;

public class playerMove : MonoBehaviour {
	public int score = 0;
	public int subscore = 0;
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
		subscore++;
		if (subscore == 50) {
			subscore = 0;
			score++;
		}
		GUIManager.setScore (score);
		Frame frame = controller.Frame ();
		
		//GestureList gestures = frame.Gestures();
		
		//get hand, find axis of rotation and get angle
		Hand hand = frame.Hands[0];
		float pitch = hand.Direction.Pitch;
		float yaw = hand.Direction.Yaw;


		//CharacterController controller= GetComponent <CharacterController>();
		//transform.Translate(Input.GetAxis ("Horizontal") *Time.deltaTime, Input.GetAxis ("Vertical") *Time.deltaTime, 0f);
		if (yaw >= 3.14 || pitch >= 3.14) {
			yaw = 0.0f;
			pitch = 0.0f;
		}

		//transform.Translate(yaw *Time.deltaTime*10, pitch *Time.deltaTime* 10, 0f);


		float xpos = transform.localPosition.x;
		float ypos = transform.localPosition.y;

		float xtrans = yaw * Time.deltaTime * 10;
		float ytrans = pitch * Time.deltaTime * 10;

		float xfuture = xpos + xtrans;
		float yfuture = ypos + ytrans;

		if (xfuture <= -4 || xfuture >= 5) {
			xtrans = 0f;
		}
		if (yfuture <= 1 || yfuture >= 10) {
			ytrans = 0f;
		}

		transform.Translate (xtrans, ytrans, 0f);

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Spawn") {
			int lives = GUIManager.getLives ();
			lives--;
			if (lives > 0) {
				GUIManager.setLives (lives);
			} else if (lives == 0) {
				GUIManager.setLives (lives);
				GUIManager.endGame (score);
			}
		}

	}
}