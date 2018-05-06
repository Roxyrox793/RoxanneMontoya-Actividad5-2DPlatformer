﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charactercontrol : MonoBehaviour {
	float speed = 0.25f;
	int coins = 0;

	public Text contadorCoins;

	// Use this for initialization
	void Start () {

	}

	void OnCollisionEnter2D(Collision2D coll) {


		if(coll.gameObject.tag == "Coins"){
			coins = coins + 1;
			contadorCoins.text = coins.ToString();


		}


	}
	

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.gameObject.transform.Translate (speed, 0f, 0f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.gameObject.transform.Translate (-speed, 0f, 0f);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 3, ForceMode2D.Impulse);


		}
	}
}
