using UnityEngine;
using System.Collections;

public class vehicleMovement : MonoBehaviour {
	float vel = 1000;
	// Use this for initialization
	void Start () {
	
	}
	void FixedUpdate () {
		GetComponent<Rigidbody>().MovePosition(transform.position - Vector3.right * vel * Time.deltaTime);
	}
}
