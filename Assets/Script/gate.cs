﻿using UnityEngine;
using System.Collections;

public class gate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	



	}

	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "Player") {	
			{
				Debug.Log("Door");
				Destroy(gameObject);
				Application.LoadLevel("scene2");

				//Debug.Log(login_database.id_acc);


			}

		}
}
}