using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Textscore : MonoBehaviour {
	public Text text;
	public int Score;
	public int Level;
	int Hasrest;
	// Use this for initialization
	void Start () {
		Score = 0;
		text.text = "Score:" + Score;
	}

	// Update is called once per frame
	void Update () {
		text.text = "Score:" + Score;
		if (Score == 5) {
			if(Hasrest == 0){
				Hasrest = 1;
				StartCoroutine (reset ());
			}
		}
	}
	IEnumerator reset (){
		Level++;
		yield return new WaitForSeconds (1.5f);
			Score = 0;
			Hasrest = 0;
	}
}
