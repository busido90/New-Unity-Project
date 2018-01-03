using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomwallcontroller : MonoBehaviour {

	// Use this for initialization
	public void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag=="wall")
		{
			Destroy(collision.gameObject);
		}
	}
}
