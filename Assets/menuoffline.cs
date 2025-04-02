using UnityEngine;
using System.Collections;

public class menuoffline : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.F1))
		{

			Application.LoadLevel("stage_1");
			login_database.usernamesent = ("offline");

		}
		if(Input.GetKeyDown(KeyCode.F5))
		{
			
			Application.LoadLevel("stage_5");
			login_database.usernamesent = ("offline");
			
		}



	}




}
