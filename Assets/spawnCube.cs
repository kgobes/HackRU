using UnityEngine;
using System.Collections;

public class spawnCube : MonoBehaviour {

	public float speed = 100.0f;
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
		transform.localPosition -= transform.forward * speed * Time.deltaTime;
		if (transform.localPosition.z <= -30) {
			transform.localPosition = new Vector3(Random.Range (-4.0f, 4.0f), 1.0f, 50.0f);
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
