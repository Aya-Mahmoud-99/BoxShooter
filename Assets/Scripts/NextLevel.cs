﻿using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	// respond on collisions
	void OnCollisionEnter(Collision newCollision)
	{
		Debug.Log("da5al hena");

		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Projectile") {
			// call the NextLevel function in the game manager
			Debug.Log("da5al");

			GameManager.gm.NextLevel();
		}
	}
}
