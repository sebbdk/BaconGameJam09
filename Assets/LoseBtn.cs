using UnityEngine;
using System.Collections;

public class LoseBtn : MonoBehaviour {

	public void Lose() {
		Application.LoadLevel(Application.loadedLevel);
	}
}
