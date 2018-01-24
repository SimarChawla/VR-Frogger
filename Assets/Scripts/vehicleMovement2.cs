using UnityEngine;
using System.Collections;

public class vehicleMovement2 : MonoBehaviour {
		float vel = 1000;
		// Use this for initialization
		void Start () {

		}
		void FixedUpdate () {
			GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.right * vel * Time.deltaTime);
		}
	}
