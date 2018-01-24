using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	public GameObject UICanvas;
	public GameObject Reticule;
	public void onDeath(){
		UICanvas.SetActive(true);
		Reticule.SetActive (true);
		GetComponent<Rigidbody> ().isKinematic = true;

	}
}
