using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void OnTriggerEnter(Collider collision){

		if (collision.tag == "Player") {
			
			Destroy (gameObject);

		}
	}
}
