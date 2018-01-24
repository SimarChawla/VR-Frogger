using UnityEngine;
using System.Collections;

public class LaneSpawner : MonoBehaviour {

	enum LaneType {Safe, Danger};


	public GameObject[] safeLanePrefabs;
	public GameObject[] dangerLanePrefabs;
	public GameObject player;
	LaneType lastLaneType= LaneType.Safe;
	public float laneSpawn = 30000;
	int offset = 0;

	void Update () {
		while(offset<laneSpawn+player.transform.position.z){
			createRandomLane(offset);
			offset += 1000;
		}
	}



	void createRandomLane(float offset){

		GameObject lane = null;
		if (lastLaneType == LaneType.Safe) {
			lastLaneType = LaneType.Danger;
			lane = instantiateRandomLane (dangerLanePrefabs);

		} else {
			lastLaneType = LaneType.Safe;
			lane = instantiateRandomLane (safeLanePrefabs);;
		}
			
		lane.transform.SetParent(transform,false);
		lane.transform.Translate (0, 0, offset);
	}

	GameObject instantiateRandomLane(GameObject[] lanes){
		int laneIndex = Random.Range (0,lanes.Length);
		return Instantiate (lanes [laneIndex]);
	}

}
