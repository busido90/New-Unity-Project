using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour {

	[SerializeField] private Rigidbody rigitBody;

	private float Accel = 20.0f;

	private float preDirect = 0f;

	// Update is called once per frame
	void Update () {
		float direction = Input.GetAxisRaw( "Horizontal" );;


		if(preDirect * direction > 0){
			direction = 0;
		}

		rigitBody.AddForce(
			transform.right * direction * Accel,
			ForceMode.Impulse);

		preDirect = direction;

	}
}
