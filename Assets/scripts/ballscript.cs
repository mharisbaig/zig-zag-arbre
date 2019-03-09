using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour {

	private Rigidbody mybody;
	private bool rollleft;
	public float speed = 5f;

	void Awake (){

		mybody = GetComponent <Rigidbody> ();
		rollleft = true;
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckInput ();
	}

	void FixedUpdate (){
		if (rollleft) {

			mybody.velocity = new Vector3 (-speed, Physics.gravity.y, 0f);
		}
		else{
		
			mybody.velocity = new Vector3 (0f, Physics.gravity.y, speed);
		}

	}
	void CheckInput (){

		if (Input.GetMouseButtonDown (0)) {


		}

	}
}
