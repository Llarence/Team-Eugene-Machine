using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Textscore : MonoBehaviour {
	
	public Text text;
	public int Score;
	public int Level;
	int Hasrest;
	public Vector3[] LS;
	public GameObject g;
	public GameObject g1;

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
		if (Input.GetKeyDown ("z") && Input.GetKey ("m") && Input.GetKey ("p")) {
			StartCoroutine (reset ());
		}
	}
	IEnumerator reset (){
		Level++;
		g.transform.position = new Vector3 (-17, 0, -44);
		yield return new WaitForSeconds (1.5f);
		Score = 0;
		Hasrest = 0;
		g.transform.position = LS [Level - 1];
		Vector3 pos = LS [Level - 1];
		pos = new Vector3 (pos.x, pos.y + 2.5f, pos.z);
		g1.transform.position = pos;
	}
}
