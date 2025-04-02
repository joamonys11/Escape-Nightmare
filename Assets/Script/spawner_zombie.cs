using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class spawner_zombie : MonoBehaviour {

	public GameObject dnaenemyprefab;
	public List<Transform> locator  = new List<Transform>();
	public float timePos = 0f;
	public float  duration = 1f;
	// Use this for initialization
	public void spwanen()
	{
		int randkey = Random.Range (0, locator.Count);
		Transform spwan = locator [randkey];
		Instantiate (dnaenemyprefab, spwan.position, spwan.rotation);
		
		
		
	}
	
	void Start () {
		locator = GetComponentsInChildren<Transform> ().ToList();
		locator.Remove (transform);
		spwanen ();
	}
	
	// Update is called once per frame
	void Update () {
		timePos += Time.deltaTime;
		if (timePos >= duration) {
			timePos = 0f;
			duration = Random.Range(10f,20f);
			spwanen();
		}
		
	}
}
