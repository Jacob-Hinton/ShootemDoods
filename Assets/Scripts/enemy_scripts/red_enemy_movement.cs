using UnityEngine;
using System.Collections;

public class red_enemy_movement : MonoBehaviour {

	public float speed;
	public float space = 1.0F;
	public Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = transform.position;
	}

	// FixedUpdate called at regular intervals
	void FixedUpdate () {
		transform.position += Vector3.left * speed * Time.deltaTime;
	}

	float getX() {
		return transform.position.x;
	}

	float getY() {
		return transform.position.y;
	}


}