using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour {
	public Material bright;
	public Material dark;
	GameObject Text;
	Textscore script;
	int HasActivated;
	// Use this for initialization
	void Start () {
 		Text = GameObject.Find ("Text");
		script = Text.GetComponent<Textscore> ();
		HasActivated = 0;
	}

	// Update is called once per frame
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "Player") {
			print (GetComponent<Renderer> ().material);
			if (HasActivated == 0){
				script.Score++;
			}
			HasActivated = 1;
			GetComponent<Renderer> ().material = bright;
		}
	}
}
