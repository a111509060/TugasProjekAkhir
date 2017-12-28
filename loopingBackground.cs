using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopingBackground : MonoBehaviour {

	private BoxCollider2D colliderTanah;
	private float groundHorizontalLength;
	// Use this for initialization
	void Start () {
		colliderTanah = GetComponent<BoxCollider2D> ();
		groundHorizontalLength = colliderTanah.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -groundHorizontalLength) {
			RepositionBackground ();
		}
		
	}
	private void RepositionBackground()
	{
		Vector2 groundOffset = new Vector2 (groundHorizontalLength * 2f, 0);
		transform.position = (Vector2)transform.position + groundOffset;
	}
}
