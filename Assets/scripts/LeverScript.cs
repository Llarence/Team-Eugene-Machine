using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour {
	public Transform T;
	public float movey;
	public float movex;
	public float movez;
	int O;
	int Ti;
	public int Tis;
	Vector3 D;
	bool Di = false;
	void start () {
		O = 0;
	}

	void Update () {
		if (Di == false) {
			movey = movey / Tis;
			movex = movex / Tis;
			movez = movez / Tis;
			Di = true;
		}
		if (O == 1 && Ti >= 1) {
			D.Set(movex, movey, movez);
			print ("Moving");
			print (D);
			print (T.position);
			Ti = Ti - 1;
			T.position += D;
			print (T.position);
		}
	}

	void OnTriggerStay () {
			print ("Hitplayer");
			if (O == 0) {
				print (Ti);
				O = 1;
				Ti = Tis;
				print (Ti);
		}
	}
}
