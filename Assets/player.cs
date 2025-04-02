using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class player : MonoBehaviour {
	public Text timerLabel;
	//private Animator timeanim;
	//public GameObject go;

	void Awake(){

		if(timerLabel.text == null)
		{
timerLabel.text = "offline";


		}




	}

	void Update() {
		

	
		

		
		
		//update the label value
		timerLabel.text = (login_database.usernamesent);
		//Debug.Log (login_database.usernamesent);
	}
}