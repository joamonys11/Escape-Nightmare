using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Bot_zombie : MonoBehaviour {

	public Transform target;
	public float moveSpeed = 50f;
	public int rotationSpeed;
	public float  duration = 1f;
	public GameObject dnaenemyprefab;
	public Transform bompoint;
	UnityEngine.AI.NavMeshAgent nav;
	private Animator anim;
	public float range = 1.0f;
	public float attackRange = 10f;
	void Start () 
	
	{
		anim = GetComponent<Animator>();
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		
	}
	
	bool canHit = true;
	void Update () {


		Destroy(gameObject,360f);
		
		
		float distance = Vector3.Distance (target.position, transform.position);
		

		
		if (distance <= range) {

			nav.SetDestination (target.position);
			Debug.Log("Range "+range);
			Debug.Log("ATTTRange "+attackRange);
		
		}
	//	Debug.Log (distance);
		if( distance <= attackRange)
{


			//Debug.Log ("Stop");
			//Debug.Log (distance);
			if(canHit){
				canHit = false;
				Debug.Log("hit");
				anim.Play("attack");
				example.OnDamage(10);
					//Instantiate (dnaenemyprefab, bompoint.position, bompoint.rotation);
				Destroy(gameObject,1.5f);

			}

			
		}
		
		
		
	}




}







	


