using UnityEngine;
using System.Collections;

public class EndMaze : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		Application.LoadLevel(0);
	}
}
