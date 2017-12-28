using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipa : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<burung> () != null) {
			pengaturanGame.instance.BurungdapatScore ();
		}
	}
}
