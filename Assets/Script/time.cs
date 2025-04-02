using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class time : MonoBehaviour {
	public Text timerLabel;
	private Animator timeanim;
	public static float timer = 10;
	public GameObject go;
	void Update() {


		timeanim =  GetComponent<Animator> ();
		timer -= Time.deltaTime;

		if (timer <= 15)
		{
			timerLabel.color = Color.red;
			timeanim.Play("timebing");
		}
		if (timer < 1) {
			Time.timeScale = 0;
			go.SetActive(true);
			Screen.lockCursor = false;
			//timer += 50;
				//Debug.Log("Died");
			//Application.LoadLevel("Lose");
			timer = 0; 
			gameObject.SetActive(false);
		}

		
		//update the label value
		timerLabel.text = string.Format ("      {0:00}", timer);

	}
	void Start()
	{
		timerLabel.color = Color.white;
		timer = 120;
		Time.timeScale = 1;

	}
}