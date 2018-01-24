using UnityEngine;
using System.Collections;

public class HudRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Camera camera = transform.parent.GetComponentInChildren<Camera>();
		var projLookDirection = Vector3.ProjectOnPlane (camera.transform.forward, Vector3.up);
		transform.rotation=Quaternion.LookRotation (projLookDirection);
	}
}
