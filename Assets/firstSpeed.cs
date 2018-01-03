using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstSpeed : MonoBehaviour {

	[SerializeField] private Rigidbody rigitbody;

	// Use this for initialization
	void Start () {
		this.rigitbody.AddForce(new Vector3(0,0,2000));
	}

	public void OnCollisionEnter(Collision collision){
		this.rigitbody.AddForce(new Vector3(0,0,200));

	}

//	void Update(){
//		this.rigitbody.velocity = new Vector3(0,0,10);
//	}

}
		
		
