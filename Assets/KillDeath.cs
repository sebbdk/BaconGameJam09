using UnityEngine;
using System.Collections;

public class KillDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z < -10) {
			Destroy(gameObject);
		}
	}
}
