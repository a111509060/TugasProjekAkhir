using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipapool : MonoBehaviour {

	public int ukuranpipapool = 5;
	public GameObject pipaPrefabs;
	public float spawnRate= 4f;
	public float pipaMin = -1f;
	public float pipaMax = 3.5f;

	private GameObject[] columns;
	private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
	private float waktuSejakSpawnedTerakhir;
	private float spawnXPosition = 10f;
	private int currentPipa = 0;

	// Use this for initialization
	void Start () {
		columns = new GameObject[ukuranpipapool];
		for (int i = 0; i < ukuranpipapool; i++) {
			columns [i] = (GameObject)Instantiate (pipaPrefabs, objectPoolPosition, Quaternion.identity);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		waktuSejakSpawnedTerakhir += Time.deltaTime;

		if (pengaturanGame.instance.gameOver == false && waktuSejakSpawnedTerakhir >= spawnRate) {
			waktuSejakSpawnedTerakhir = 0;
			float spawnYPosition = Random.Range (pipaMin, pipaMax);		
			columns [currentPipa].transform.position = new Vector2 (spawnXPosition, spawnYPosition);
			currentPipa++;
			if (currentPipa >= ukuranpipapool) {
				currentPipa = 0;
			
			}
		}
	}
}
