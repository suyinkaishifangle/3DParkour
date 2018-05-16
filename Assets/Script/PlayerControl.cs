using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	public int Hp = 1;
	public float Speed = 0.05f;

	private Rigidbody Body;

	public Animator ani;
	private Transform trans;
	public float side = 0;
	// Use this for initialization
	void Start () {
		Body = GetComponent<Rigidbody> ();
		ani = GetComponent<Animator> ();
		trans = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		motion ();

	}

	public void motion(){
		
		//trans.Translate (Vector3.forward * Speed, Space.Self);  

		if (Input.GetButton ("Jump")) {
			Jump ();
		}

		if (Input.GetKeyDown (KeyCode.A) && side>-1) {
			ani.Play ("RunL", 0);

			trans.Translate (Vector3.left * 1.7f, Space.Self);
			side--;
		}
		if (Input.GetKeyDown (KeyCode.D) && side<1) {
			ani.Play ("RunR", 0);

			trans.Translate (Vector3.right * 1.7f, Space.Self);
			side++;
		}
	}

	public void Jump(){
		if (Hp > 0) {
			ani.Play ("Jump", 0);

		}
	}
	private void OnTriggerEnter(Collider collision){
		if (collision.tag == "obstacle" && Hp > 0) {
			Hp--;
			if (Hp <= 0) {
				
				ani.Play ("Die", 0);

				Destroy(Body);
			}
		}
	}

}
