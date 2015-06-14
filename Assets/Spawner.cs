using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public float spawnCD = 1f;
	private float lastSpawn = 0;

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
				spawn ();
				spawn ();
				lastSpawn = Time.time;
			}

			if (Time.time - lastSpawnCDReduceCD > spawnCDReduceCD) {
				spawnCD -= spawnCD/20;
				lastSpawnCDReduceCD = Time.time;
			}
		}
	}

	void spawn() {
		GameObject murder = Instantiate (spawnables [Mathf.RoundToInt (Random.Range (0, spawnables.Length))]);

		Vector3 offset = new Vector3 (Random.Range (-2, 2), Random.Range (2, -2), 0);
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
