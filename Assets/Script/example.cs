using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class example : MonoBehaviour {
	//Variables
	public GameObject zonea,zoneb,zonec,full100,full80,full50,full30,full10;
	//public AudioClip walk;
	AudioSource audio;
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F; 
	public float gravity = 20.0F;
	//private Vector3 moveDirection = Vector3.zero;
	//public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
	//public RotationAxes axes = RotationAxes.MouseXAndY;
//	public float sensitivityX = 15F;
	//public float sensitivityY = 15F;
	//public float minimumX = -360F;
//	public float maximumX = 360F;
	public static int itemcount;
	//public float minimumY = -60F;
//	public float maximumY = 60F;
//	float rotationX = 0F;
//	float rotationY = 0F;
	public GameObject flashlights;
	//string url_pickup = "http://192.168.100.26/game/pickitem";
	public GameObject doorgate;
	public static float hp;
	public static float damage;
	public GameObject[] key;
	public int reduce;
	public  GameObject gameoverscene,star1a,star2a,star3a,star1n,star2n,star3n,nextscene;
	//public float timeflash = 100; 
	
	
	Quaternion originalRotation;
	
	
	void Update() {


		if(Input.GetKeyDown(KeyCode.Z))
		{

			Destroy(GameObject.FindWithTag("Enemy"));


		}



			if(hp <=  0)
		{
			Screen.lockCursor = false;
			gameoverscene.SetActive(true);
			Time.timeScale = 0;
		}

		
		
//		if (flashlight.energy <= 100 && flashlight.energy > 10f) {
//			flashlight.energy += 0.2f * Time.deltaTime; 
//			Debug.Log (flashlight.energy += 0.2f * Time.deltaTime);
//			Debug.Log ("Charging");
//			if (flashlight.energy >= 100) {
//				charging.SetActive (false);
//			} else {
//				charging.SetActive (true);
//				
//			}
//		}
		//		if (timeflash >=49 && timeflash <=30 ) {
		//			
		//			full100.SetActive(false);
		//			full80.SetActive(false);
		//			full50.SetActive(true);
		//			Debug.Log("50");
		//		}
		//		if (timeflash >=29 && timeflash <=10 ) {
		//			
		//			full100.SetActive(false);
		//			full80.SetActive(false);
		//			full50.SetActive(false);
		//			full30.SetActive(true);
		//			Debug.Log("30");
		//		}
		//		if (timeflash >=9 && timeflash <=0 ) {
		//			
		//			full100.SetActive(false);
		//			full80.SetActive(false);
		//			full50.SetActive(false);
		//			full30.SetActive(false);
		//			full10.SetActive(true);
		//			Debug.Log("10");
		//		}
		
		if(Input.GetKeyDown(KeyCode.P))
		   {
			
			flashlight.energy += 100;
			doorgate.SetActive(true);
			time.timer +=100;
		}

		
		
	
		
		if (flashlight.energy >= 0) {
			if (Input.GetKey (KeyCode.F)) {

				//charging.SetActive (false);
				flashlight.energy -= reduce * Time.deltaTime;
				flashlights.SetActive (true);
				
				if (flashlight.energy == 100) {
					reduce = 1;
					//full100.SetActive(true);
					Debug.Log ("100");
				}
				if (flashlight.energy <= 80) {
					reduce = 1;
					full100.SetActive (false);
					full80.SetActive (true);
					Debug.Log ("80");
				}
				if (flashlight.energy <= 50) {
					reduce = 1;
					full100.SetActive (false);
					full80.SetActive (false);
					full50.SetActive (true);
					Debug.Log ("50");
				}
				
				if (flashlight.energy <= 30) {
					reduce = 1;
					full100.SetActive (false);
					full80.SetActive (false);
					full50.SetActive (false);
					full30.SetActive (true);
					Debug.Log ("30");
				}
				if (flashlight.energy <= 10) {
					
					reduce = 1;
					full100.SetActive (false);
					full80.SetActive (false);
					full50.SetActive (false);
					full30.SetActive (false);
					full10.SetActive (true);
					Debug.Log ("10");
				}
				
				
				
				
			} 
		}
		if (Input.GetKeyUp (KeyCode.F)) {
			flashlights.SetActive (false);

			
			
		}
		
		if (Input.GetKeyDown (KeyCode.W)) {
			//audio.PlayOneShot(walk, 0.7F);
			audio.Play ();
		} else if (Input.GetKeyUp (KeyCode.W)) {
			audio.Stop ();
			
		}
		
//		if (axes == RotationAxes.MouseXAndY) {
//			// Read the mouse input axis
//			rotationX += Input.GetAxis ("Mouse X") * sensitivityX;
//			rotationY += Input.GetAxis ("Mouse Y") * sensitivityY;
//			
//			rotationX = ClampAngle (rotationX, minimumX, maximumX);
//			rotationY = ClampAngle (rotationY, minimumY, maximumY);
//			
//			Quaternion xQuaternion = Quaternion.AngleAxis (rotationX, Vector3.up);
//			Quaternion yQuaternion = Quaternion.AngleAxis (rotationY, -Vector3.right);
//			
//			transform.localRotation = originalRotation * xQuaternion * yQuaternion;
//		} else if (axes == RotationAxes.MouseX) {
//			rotationX += Input.GetAxis ("Mouse X") * sensitivityX;
//			rotationX = ClampAngle (rotationX, minimumX, maximumX);
//			
//			Quaternion xQuaternion = Quaternion.AngleAxis (rotationX, Vector3.up);
//			transform.localRotation = originalRotation * xQuaternion;
//		} else {
//			rotationY += Input.GetAxis ("Mouse Y") * sensitivityY;
//			rotationY = ClampAngle (rotationY, minimumY, maximumY);
//			
//			Quaternion yQuaternion = Quaternion.AngleAxis (-rotationY, Vector3.right);
//			transform.localRotation = originalRotation * yQuaternion;
//		}
		
//		
//		CharacterController controller = GetComponent<CharacterController> ();
//		// is the controller on the ground?
//		if (controller.isGrounded) {
//			//Feed moveDirection with input.
//			moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
//			
//			moveDirection = transform.TransformDirection (moveDirection);
//			//Multiply it by speed.
//			moveDirection *= speed;
//			//Jumping
//			if (Input.GetButton ("Jump"))
//				moveDirection.y = jumpSpeed;
//			
//		}
//		//Applying gravity to the controller
//		moveDirection.y -= gravity * Time.deltaTime;
//		//Making the character move
//		controller.Move (moveDirection * Time.deltaTime);
//	}
//	
	}






	void Start ()
	{	
		flashlights.SetActive (false);
		gameoverscene.SetActive(false);
		Time.timeScale = 1;

		Debug.Log(Time.timeScale);

		//gameoverscene.SetActive (false);

	

		reduce = 2;
		
		audio = GetComponent<AudioSource> ();
		//audio.Play ();
		Screen.lockCursor = true;
		
		hp = 100;
		damage = 5;
		itemcount = 0;
		Debug.Log (itemcount + "Gate");
		
		// Make the rigid body not change rotation
//		if (GetComponent<Rigidbody> ()) {
//			GetComponent<Rigidbody> ().freezeRotation = true;
//			originalRotation = transform.localRotation;
//		}
		
		
	}



	void OnTriggerEnter (Collider col)
	{
			
			

			if (col.gameObject.tag == "Key")
			{
			Debug.Log("Key");

			itemcount++;
			if(itemcount == 1)
			{
				key[4].SetActive(true);
				Debug.Log(itemcount);
				
			}
			
			if(itemcount == 2)
			{
				key[3].SetActive(true);

				
			}
			if(itemcount == 3)
			{
				key[2].SetActive(true);

				
			}
			if(itemcount == 4)
			{
				key[1].SetActive(true);

				
			}
			if(itemcount == 5)
			{
				key[0].SetActive(true);

				
			}

			if(itemcount==5)
			{
				doorgate.SetActive(true);

			}
			Destroy(col.gameObject);	

		}

		if(col.gameObject.tag == "a")
		{
			zonea.SetActive(true);
			Destroy(col.gameObject);
			Debug.Log("a");


		}

		if(col.gameObject.tag == "b")
		{



			zoneb.SetActive(true);
			Destroy(col.gameObject);
			Debug.Log("b");


		}

		if(col.gameObject.tag == "c")

		{

			zonec.SetActive(true);
			Destroy(col.gameObject);
			Debug.Log("c");

		}

		if (col.gameObject.tag == "door") {
			Screen.lockCursor = false;
			Debug.Log(col.gameObject.name);
			Time.timeScale = 0;
			float timecount = time.timer;
			nextscene.SetActive(true);

			
			if( timecount > 1 && timecount <=40)
			{
				star1a.SetActive(true);
				star2n.SetActive(true);
				star3n.SetActive(true);

			}
			if( timecount > 41 && timecount <= 60)
			{
				star1a.SetActive(true);
				star2a.SetActive(true);
				star3n.SetActive(true);
				
			}
			if( timecount > 61 && timecount <= 120)
			{
				star1a.SetActive(true);
				star2a.SetActive(true);
				star3a.SetActive(true);
				
			}


		}


		}
//	
//	public static float ClampAngle (float angle, float min, float max)
//	{
//		if (angle < -360F)
//			angle += 360F;
//		if (angle > 360F)
//			angle -= 360F;
//		return Mathf.Clamp (angle, min, max);
//	}





	public static void OnDamage(float d)
	{
		hp -= d;
		if (hp <= 0) {
			

			Debug.Log("Died");
			//Application.LoadLevel ("Lose");
			//Application.LoadLevel("ui");
		}
	}
	
//	public void minimapon(bool d)
//	{
//		minimapbool = d; 
//
//		minimap.SetActive(minimapbool);
//		Debug.Log("Boolean Value of minimap "+minimapbool);
//	}
//	
}