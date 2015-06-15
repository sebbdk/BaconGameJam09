using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

	public float spawnCD = 1f;
	private float lastSpawn = 0;
	private int fjamp = 0;

	public float spawnCDReduceCD = 10f;
	private float lastSpawnCDReduceCD = 0;

	public GameObject[] spawnables;

	private bool started;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (started) {
			if (Time.time - lastSpawn > spawnCD) {

				for(int x = 0; x < 10; x++) {
					spawn ();
				}
				lastSpawn = Time.time;

				fjamp++;
				fjamp++;

				GameObject.Find("fjamp").GetComponent<Text>().text = fjamp.ToString() + " FJÆMPS";
			}

			if (Time.time - lastSpawnCDReduceCD > spawnCDReduceCD) {
				spawnCD -= spawnCD/20;
				lastSpawnCDReduceCD = Time.time;
			}
		}
	}

	void spawn() {
		GameObject murder = Instantiate (spawnables [Mathf.RoundToInt (Random.Range (0, spawnables.Length))]);

		Vector3 offset = new Vector3 (Random.Range (-5, 5), Random.Range (5, -5), 0);
		murder.transform.position = this.transform.position + offset;

		murder.GetComponent<Rigidbody> ().velocity = new Vector3(0,0, -20f);
	}

	public void startGame() {
		started = true;
	}

	public void pause() {
		started = false;
	}
}
