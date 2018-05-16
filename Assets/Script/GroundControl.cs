using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour {
	public float Speed = 0.05f;

	private Transform trans;
	//地面预设题
	public GameObject[] Ground;
	//玩家
	private PlayerControl playerControl;

	// Use this for initialization
	void Start () {
		trans = gameObject.GetComponent<Transform> ();

		playerControl = GameObject.FindWithTag ("Player").GetComponent<PlayerControl> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerControl.Hp <= 0) {
			return;
		}
		trans.Translate (Vector3.back * Speed, Space.Self); 

		if (trans.position.z < -30.0f) {
			
			trans.transform.position =new Vector3(0, 0, trans.transform.position.z + 100);

			foreach (Transform trans in transform) {
				Destroy (trans.gameObject);
			}
			Instantiate(Ground[Random.Range(0,Ground.Length)],trans);
		}




		Newscene ();
	}
	public void Newscene(){
		

	}
}
