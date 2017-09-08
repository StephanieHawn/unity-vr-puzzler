using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {


	bool locked = false;
	//bool unlocked;

	public GameObject doorLeft;
	public GameObject doorRight;

	public Vector3 origPositionL;
	public Vector3 origPositionR;

	public Animator doorL;
	public Animator doorR;

	void Awake(){
	}

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if(locked == true){
			Debug.Log ("door update door.cs");
			doorL.SetBool ("door-transition", true);
			doorR.SetBool ("door-trans-r", true);
			//doorL.SetTrigger ("testL");
			//doorR.SetTrigger ("test");
		}
	}

	public void Unlock(){
		locked = true;
		Debug.Log ("door unlock from door.cs");
	}

	public void DoorOrigPosition()
	{
		//doorL.SetBool ("door-transition", false);
		//doorR.SetBool ("door-trans-r", false);
		//doorL.StopPlayback ();
		//doorR.StopPlayback ();

		//doorL.ResetTrigger ("testL");


		doorLeft.transform.position = origPositionL;
		doorRight.transform.position = origPositionR;

		Debug.Log ("DoorOrigPosition from door.cs");
	}

}
