using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pengaturanGame : MonoBehaviour {

	public static pengaturanGame instance;
	public Text scoreText;
	public GameObject GameOverText;
	public bool gameOver = false;
	public float scrollSpeed = -10f;

	private int score = 0;


	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} 
		else if (instance != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	public void BurungdapatScore()
	{
		if (gameOver) {
			return;
		}
		score++;
		scoreText.text = "Sekor:  " + score.ToString ();
	}
	public void BurungMati()
	{
		GameOverText.SetActive (true);
		gameOver = true;
	}

}
