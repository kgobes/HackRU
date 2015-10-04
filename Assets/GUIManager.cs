using UnityEngine;
using System.Collections;

public class GUIManager : MonoBehaviour {
	public static bool done = false;
	public static GUIText Score;
	public static GUIText Lives;
	public static GUIText EndGame;
//	public static GUIText loselife;

	public static int scoreNum;
	public static int livesNum;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1.0f;
		scoreNum = 0;
		livesNum = 3;
		Score = GameObject.Find ("Score").GetComponent<GUIText> ();
//		loselife = GameObject.Find ("LoseLife").GetComponent<GUIText> ();
		Lives = GameObject.Find ("Lives").GetComponent<GUIText> ();
		EndGame = GameObject.Find ("EndGame").GetComponent<GUIText> ();
		Score.text = "Score: " + scoreNum;
		Lives.text = "Lives: " + livesNum;
		EndGame.enabled = false;
		Score.enabled = true;
		Lives.enabled = true;
//		loselife.enabled = false;
		setLives(3);
		setScore (0);

	}


	public static void setScore(int scor){
		scoreNum = scor;
		Score.text = "Score: " + scoreNum;
	}

	public static void setLives(int liv){
		livesNum = liv;
		Lives.text = "Lives: " + livesNum;
	}

	public static int getLives(){
		return livesNum;
	}

	public static int getScore(){
		return scoreNum;
	}
	public static void endGame(int finalScore){
		Score.enabled = false;
		EndGame.enabled = true;
		if (Time.timeScale == 1.0f)            
			Time.timeScale = 0.0f;        
		else
			Time.timeScale = 1.0f;

		EndGame.text = "Game Over \n Score: " + finalScore;

		setScore (0);
		done = true;



	}

	/*public static IEnumerator loadLevel(){
		print ("in loadLevel");
		yield return new WaitForSeconds(3); 
		Application.LoadLevel (0);
	}*/
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Start") && (done)) {
			done = false;
			Application.LoadLevel(0);
		}
	}
}
