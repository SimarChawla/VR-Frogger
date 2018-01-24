using UnityEngine;
using System.Collections;

public class TreeSpawner : MonoBehaviour {
	public GameObject treePrefab;
	public int minTree=2;
	public int maxTree=10;
	// Use this for initialization
	void Start () {
		int treeNumber = Random.Range(minTree,maxTree);
		for (int i = 0; i < treeNumber; i++){
			createTree ();
		}
	}

	void createTree() {
		var Tree = Instantiate (treePrefab);
		Tree.transform.parent = transform;
		Tree.transform.localPosition = new Vector3(Random.Range (-5000, 5000),0, Random.Range (-500, 500));
	}

	// Update is called once per frame
	void Update () {
	
	}
}
