using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public GameObject GO;

	public float score=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GO.GetComponent<Text> ().text = "scroce:" + score;
	}
	private void OnTriggerEnter(Collider collision){
		if (collision.tag == "gold") {
			score++;

		}
	}
}
