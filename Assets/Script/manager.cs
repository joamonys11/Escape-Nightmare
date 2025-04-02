using UnityEngine;
using System.Collections;

public class manager : MonoBehaviour {
	private Animator backanim;
	public GameObject winner,menu;

	// Use this for initialization
	void Start () {
		//backanim = GetComponent<Animator> ();
		Time.timeScale = 1;

	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyDown(KeyCode.Escape))
		{
			menu.SetActive(true);
			Time.timeScale = 0;
			Screen.lockCursor = false;

		}



	}


	public void checkdebug(){



		//backanim.Play ("b_tutorial");

		Debug.Log ("Yeahh");
	
	}
	public void exit()
	{

		Application.Quit ();
	}

	public void returnmain()
	{
		Debug.Log("Click");
		Application.LoadLevel("ui");


	}

	public void next2()
	{
		Application.LoadLevel("stage_2");
		example.hp = 100;
		
	}
	public void next3()
	{
		Application.LoadLevel("stage_3");
		
		
	}
	public void next4()
	{
		Application.LoadLevel("stage_4");
		
		
	}


	public void next5()
	{
		Application.LoadLevel("stage_5");
		
		
	}

	public void next6()
	{
		winner.SetActive(true);
		StartCoroutine(winnerscene());
	

		
	}

	IEnumerator winnerscene()
	{



		yield return new WaitForSeconds(5);

		Application.LoadLevel("ui");
	}


	public void backtogame()
	{

		menu.SetActive(false);
		Time.timeScale = 1;
		Screen.lockCursor = true;

	}




}
