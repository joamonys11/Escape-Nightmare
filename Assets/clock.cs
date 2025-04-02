using UnityEngine;
using System.Collections;

public class clock : MonoBehaviour {
	private Animator timeanima;
	// Use this for initialization
	void Start () {
		timeanima = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	

		if (time.timer <= 15) {

			timeanima.Play("hourglass");

		}
	}


}
