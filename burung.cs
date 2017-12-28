﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burung : MonoBehaviour {

	public float upForce = 200f;

	private bool isMati = false;
	private Rigidbody2D rb2d;
	private Animator anim;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isMati == false) {
			if (Input.GetMouseButtonDown (0)) {
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce (new Vector2 (0, upForce));
				anim.SetTrigger ("Flap");
			}
		}
	}
	void OnCollisionEnter2D()
	{
		rb2d.velocity = Vector2.zero;
		isMati = true;
		anim.SetTrigger ("Die");
		pengaturanGame.instance.BurungMati ();
	}
}