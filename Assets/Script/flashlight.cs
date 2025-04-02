using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class flashlight : MonoBehaviour {
	public Text timerLabel;
	//private Animator timeanim;
	public static float energy = 100;
	//public float flash;
	
	void Update() {


		


	
		
//		if (timer <= 15)
//		{
//			timerLabel.color = Color.red;
//			//timeanim.Play("timebing");
//			
//		}
//		if (timer <= 0) {
//			
//			timer += 50;
//			Debug.Log("Died");
//			//Application.LoadLevel("Lose");
//			
//		}
		
		
		//update the label value
		timerLabel.text = string.Format ("{0:00}", energy);
		
	}
	void Start()
	{


		energy = 100;


	}
}