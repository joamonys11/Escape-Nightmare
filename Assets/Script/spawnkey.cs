using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class spawnkey : MonoBehaviour {
	
	public GameObject dnaenemyprefab;
	public List<Transform> locator = new List<Transform>();
	public float timePos = 0f;
	public float  duration = 1f;
	// Use this for initialization
	public void spwanen()
	{
		int randkey = Random.Range (0, locator.Count);
		Transform spwan = locator [randkey];
		Instantiate (dnaenemyprefab, spwan.position, spwan.rotation);
		locator.RemoveAt(randkey);
		
		
	}
	
	void Start () {

		locator = GetComponentsInChildren<Transform> ().ToList();
		locator.Remove (transform); 

		for (int i = 0; i < 5; i++) {
			spwanen();
		}
			

	}
	// Update is called once per frame
	void Update () {
//		timePos += Time.deltaTime;
//		if (timePos >= duration) 
//		{   Debug.Log("1");
//			timePos = 0.50f;
//			duration = Random.Range(5f,10f);
//			spwanen ();
//
//		}
		
	}
}
