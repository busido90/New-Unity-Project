using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour {

	[SerializeField] private Rigidbody rigitBody;

	private float Accel = 1.0f;

	// Update is called once per frame
	void Update () {
		float a = Input.GetAxisRaw( "Horizontal" );
		Debug.Log(a);
		rigitBody.AddForce(
			transform.right * Input.GetAxisRaw( "Horizontal" ) * Accel,
			ForceMode.Impulse);
		
	}
}
