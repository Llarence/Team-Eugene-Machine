﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
	float pitch;
	float yaw;


	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
		yaw -= Input.GetAxis("Mouse Y") * 2;
		pitch += Input.GetAxis("Mouse X") * 2;
		transform.eulerAngles = new Vector3(yaw, pitch, 0f);
		if (Input.GetKeyDown ("escape")) {
			Cursor.lockState = CursorLockMode.None;
		}

	}
}
