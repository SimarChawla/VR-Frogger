using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadNextScene (){
		int curIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(curIndex + 1);
	}

	public void ReloadScene (){
		int curIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(curIndex);
	}

	public void LoadPrevScene (){
		int curIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (curIndex - 1);
	}

	public void Quit(){
		Application.Quit();
	}

}
