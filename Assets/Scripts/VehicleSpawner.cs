﻿using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {

	public GameObject prefab;
	public float minTime=2;
	public float meanTime=2;
	float nextSpawnTime=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawnTime) {
			
			spawn ();
			nextSpawnTime = Time.time + minTime -Mathf.Log(Random.value)*meanTime;
		}

	}

	void spawn(){
		 Instantiate (prefab, transform.position, transform.rotation, transform);
	}
}
