using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	public GameObject gameOver;
	public bool isGameOver;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	/*	var v3 = Input.mousePosition;
		v3.z = transform.position.z;
		v3 = Camera.main.ScreenToWorldPoint(v3);

		transform.position = Vector3.Lerp(transform.position, v3, 0.002f);*/
		if(Input.GetMouseButton(0) && !isGameOver)
		{

			Vector3 pos = Input.mousePosition;

			pos.z = 20;
			pos = Camera.main.ScreenToWorldPoint(pos);
		
			Vector3 newPos = Vector3.Lerp(transform.position, pos, 1.5f*Time.deltaTime);

			if(newPos.x <= 2 && newPos.x >= -4 && newPos.y <= 4 && newPos.y >= -2) {
				transform.position = newPos;
			}
		}

	}


	void OnTriggerEnter(Collider col) {
		Debug.Log ("U is dead!");
		gameOver.SetActive (true);

		GameObject[] obj = GameObject.FindGameObjectsWithTag ("doom");

		foreach (GameObject o in obj) {
			o.GetComponent<Rigidbody>().velocity = new Vector3();
		}

		isGameOver = true;
	}

}
