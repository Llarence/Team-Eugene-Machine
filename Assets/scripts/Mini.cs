﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini : MonoBehaviour {
	float t;
	float w;
	Vector3 Move;
	float pitch;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		float H = Input.GetAxis ("MiniH");
		float V = Input.GetAxis ("MiniV");
		Move = new Vector3 (H, 0f, V);
		transform.Translate (Move/10);
	}
	void Update (){
		pitch += Input.GetAxis("Mouse X") * 2;
		transform.eulerAngles = new Vector3(0f, pitch, 0f);
	}
}
