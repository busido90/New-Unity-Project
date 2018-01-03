using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour {

//[SerializeField] private OnCollisionEnter OnCollisionEnter;

	// Use this for initialization
	public void OnCollisionEnter(Collision collision){
		
	
		if(collision.gameObject.tag=="obstacle")
		{
			Destroy(collision.gameObject);
		}
	}		

}
