using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour {

	public string namaScene;

	public void PindahKeScene(){
		Scene sceneIni = SceneManager.GetActiveScene ();
		if (sceneIni.name != namaScene) {
			SceneManager.LoadScene (namaScene);
		}
	}
}
