using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {

	public GameObject menuPanel;
	public GameObject caraMainPanel;
	public GameObject kreditPanel;
	// Use this for initialization
	void Start () {
		menuPanel.SetActive (true);
		caraMainPanel.SetActive (false);
		kreditPanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void MulaiClicked(){

		Application.LoadLevel (1);
	}
	public void CaraMainClicked(){
		caraMainPanel.SetActive (true);
		menuPanel.SetActive (false);
		kreditPanel.SetActive (false);
	}
	public void KreditClicked(){
		kreditPanel.SetActive (true);
		menuPanel.SetActive (false);
		caraMainPanel.SetActive (false);
}
	public void QuitClick(){
		Application.Quit ();
	}
	public void BackToMenuClicked(){
		menuPanel.SetActive (true);
		caraMainPanel.SetActive (false);
		kreditPanel.SetActive (false);
	}
}
