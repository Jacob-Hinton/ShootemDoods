using UnityEngine;
using System.Collections;

public class Player_movement : MonoBehaviour {

	public float speed;
	public float space = 1.0F;
	private Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// FixedUpdate called at regular intervals
	void FixedUpdate () {

		if (Input.GetKey (KeyCode.W)) {
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		else if (Input.GetKey (KeyCode.S)) {
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		else if (Input.GetKey (KeyCode.D)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}

		transform.position += Vector3.right * Ambient_scrolling.ambientScrollSpeed * Time.deltaTime;


	
	}
}
