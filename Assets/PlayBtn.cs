﻿using UnityEngine;
using System.Collections;

public class PlayBtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Hide () {
		gameObject.SetActive (false);

		GameObject.Find ("pd").SetActive (false);
	}
}
