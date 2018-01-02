using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour {

[SerializeField] private OnCollisionEnter OnCollisionEnter;

	// Use this for initialization
	void Start () {
		this.OnCollisionEnter(Collision: collision);
             destroy(gameobject);
        		
	}
	
	
  