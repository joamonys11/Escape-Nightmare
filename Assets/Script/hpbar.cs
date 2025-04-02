using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class hpbar : MonoBehaviour {
	Slider slider;
	public float hplose;

	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider> ();




	}


	
	// Update is called once per frame
	void Update () {

//		Bot_zombie.hp
//		slider.value = ;

		hplose = example.hp / 100;
		slider.value = hplose;
	}



}
