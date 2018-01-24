using UnityEngine;
using System.Collections;

public class Fatal : MonoBehaviour {

	Death deathComp;

	void Start(){
		deathComp = FindObjectOfType<Death> ();
	}

	void OnCollisionEnter(Collision collision){
		deathComp.onDeath();
	}
}
