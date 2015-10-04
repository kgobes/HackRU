using UnityEngine;
using System.Collections;

public class spawnCube : MonoBehaviour {

	public float speedZ = 10.0f;
	public float speedX = 7.0f;
	public float speedY = 7.0f;

	//Random rand = new Random();
	/*public Vector3 spawnObject;
	public float rateOfSpawn=0.5f; //spawn every 0.5 seconds
	private float nextSpawn=0.0f;
	public int counter = 0;*/
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void Update()
	{
		transform.localPosition -= transform.forward * speedZ * Time.deltaTime;
		transform.localPosition += transform.right * speedX * Time.deltaTime;
		transform.localPosition += transform.up * speedY * Time.deltaTime;

		if (transform.localPosition.z <= -30) {
			transform.localPosition = new Vector3(Random.Range (-4.0f, 4.0f), Random.Range (2.0f, 8.0f), 50.0f);
		}
		if (transform.localPosition.x < -4) {
			transform.localPosition += transform.right * 1;
			speedX *= -1;
		}
		if (transform.localPosition.x > 4) {
			transform.localPosition -= transform.right * 1;
			speedX *= -1;
		}

		if (transform.localPosition.y < 0.5f) {
			transform.localPosition += transform.up * Random.Range (-1.0f, 1.0f);
			speedY *= -1;
		}
		if (transform.localPosition.y > 9) {
			transform.localPosition -= transform.up * Random.Range (-1.0f, 1.0f);
			speedY *= -1;
		}


		/*if(Time.time>nextSpawn){
			nextSpawn=Time.time + rateOfSpawn;
			Vector3 spawnBox=transform.localScale;
			Vector3 position= new Vector3(Random.value * spawnBox.x, Random.value * spawnBox.x, Random.value * spawnBox.x);
			position=transform.TransformPoint(position-spawnBox/2);
			Transform obj=Instantiate(spawnObject, position, transform.rotation);
		}*/
	}
}
