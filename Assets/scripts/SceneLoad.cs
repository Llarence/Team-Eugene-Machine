using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour {


	// Use this for initialization
	public void LoadScene (string s) {
		SceneManager.LoadScene (s);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
