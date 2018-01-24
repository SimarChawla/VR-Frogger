using UnityEngine;
using System.Collections;

public class MoveFrog : MonoBehaviour {

	public float jumpAngle= 45;
	public float[] jumpSpeed = {200,400,700};
	public float jumpGroundDist = 200;
	public float jumpSpeedTol = 5;

	public int collisionCount=0;
	public int jumpCount=0;

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision collision){
		collisionCount++;
	}

	void OnCollisionExit(Collision collision){
		collisionCount--;
	}

	// Update is called once per frame
	void Update () {
		bool isGrounded = collisionCount>0;

		if (isGrounded) {
			jumpCount = 0;
		}

		if (GvrViewer.Instance.Triggered && jumpCount<jumpSpeed.Length){
			var camera = GetComponentInChildren<Camera>();

			var projectedLook = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
			var radiansToRotate = Mathf.Deg2Rad * jumpAngle;
			var notNormalizedJumpDirection = Vector3.RotateTowards (projectedLook, Vector3.up, radiansToRotate, 0);
			var jumpVector = notNormalizedJumpDirection * jumpSpeed[jumpCount];

			GetComponent<Rigidbody>().AddForce (jumpVector, ForceMode.VelocityChange);

			jumpCount++;
		}
	}
}
