﻿using UnityEngine;
using System.Collections;

public class Beast : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		GoodShip ship = other.GetComponent<GoodShip> ();
		ship.Explode ();
	}
}