﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieViewer : MonoBehaviour {

	public GameObject g;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if((g.GetComponent<Textscore>().Level) % 4 == 1){
			print("hi");
		}
	}
}
