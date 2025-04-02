using UnityEngine;
using System.Collections;

public class effect_attack_zombie : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {	

			anim.Play("attack_zombie");
			example.OnDamage (10);
			DestroyObject (gameObject);

		} 


	}

}
