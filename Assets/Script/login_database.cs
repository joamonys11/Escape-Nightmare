using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class login_database : MonoBehaviour {

	string url_login = "http://192.168.100.6/game/login";
	string url_regis = "http://192.168.100.6/game/signup";
	string username,password;
	public GameObject massage,fail,error;
	public static string id_acc;
	public static string usernamesent;

	public void SetUsername(InputField t){

		username = t.text;
		usernamesent = username;
	}
	public void SetPassword(InputField t){
		
		password = t.text;


	}
	public void login_click()
	{

		if (string.IsNullOrEmpty (username) || string.IsNullOrEmpty (password) ) {

			return;
		}

		Debug.Log ("Send username="+username+"&password="+password);
	

		

		Connector.GET (url_login+"?username="+username+"&password="+password, loginCallBack);



	}
   public static float x;

	public void loginCallBack(WWW www){
		Debug.Log ("Login Callback");
		//Debug.Log (www.text);

		Dictionary<string,object> jsonObject = MiniJSON.Json.Deserialize(www.text) as Dictionary<string,object>;

	


		if(jsonObject.ContainsKey("status")){
			if(jsonObject["status"].ToString()== "success"){
				Debug.Log(jsonObject["data"].ToString());

				Debug.Log("Login Success");

				StartCoroutine(NextScenelogin());

				Dictionary<string,object>  data = jsonObject["data"]as  Dictionary<string,object>;

//				id_acc = data["id"].ToString();
//				x = float.Parse(data["x"].ToString());

			}else if(jsonObject["status"].ToString()== "error"){

				StartCoroutine(NextScene());

				error.SetActive(true);
				StartCoroutine(errormsg());
				Debug.Log("Login Fail");


			}

		}

	}


	public void registor_click()
	{
		
		if (string.IsNullOrEmpty (username) || string.IsNullOrEmpty (password) ) {
			
			return;
		}
		
		Debug.Log ("Send username="+username+"&password="+password);
		
		
		
		Connector.GET (url_regis + "?username=" + username + "&password=" + password, regisCallback);
	
	}

	public void regisCallback(WWW www){
		Debug.Log("regisCallback");
		Debug.Log (www.text);
		
		Dictionary<string,object> jsonObject = MiniJSON.Json.Deserialize(www.text) as Dictionary<string,object>;




		if(jsonObject.ContainsKey("status")){
			if(jsonObject["status"].ToString()== "success"){
				//fail.SetActive(false);
				//success.SetActive(true);
				Debug.Log("Register Success");
				//success.SetActive(true);
				//fail.SetActive(false);
				StartCoroutine (NextScene());


			}else if(jsonObject["status"].ToString()== "error"){
				Debug.Log(jsonObject["text"].ToString());
				fail.SetActive(true);
				//success.SetActive(false);
				StartCoroutine(NextScene());
				Debug.Log("Register Fail");
				
				
			}
			
		}





}

	



	IEnumerator NextScene()
	{
		yield return new WaitForSeconds (5);
		Application.LoadLevel("ui");
		fail.SetActive(false);

	}


	IEnumerator NextScenelogin()
	{
		yield return new WaitForSeconds (10);
		Application.LoadLevel("stage_1");
		
	}
	IEnumerator errormsg()
	{

		yield return new WaitForSeconds(3);
		error.SetActive(false);
		Application.LoadLevel("ui");


	}


	public void Offlinelogin()
	{
		usernamesent = "TestOffline";
Application.LoadLevel("stage_1");

	}




}