using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstSpeed : MonoBehaviour {

	[SerializeField] private Rigidbody rigitbody;

	// Use this for initialization
	void Start () {
		this.rigitbody.AddForce(new Vector3(0,0,1000));
	}
		

	

}
