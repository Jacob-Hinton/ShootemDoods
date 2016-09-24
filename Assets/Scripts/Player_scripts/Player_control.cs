using UnityEngine;
using System.Collections;

public class Player_control : MonoBehaviour {

	public int b_speed = 20;
	public Rigidbody2D projectile;
	public float m_speed;
	public Vector3 pos;

	public Stack held_power_ups = new Stack();
	private int red_state;
	private int blue_state;
	private int yellow_state;
	// Use this for initialization
	void Start () {
		pos = transform.position;
		// held_power_ups.Push('b');
	}
	
	// FixedUpdate called at regular intervals
	void FixedUpdate () {

		if (Input.GetKey (KeyCode.W)||Input.GetAxis("Vertical")>0) {
			transform.position += Vector3.up * m_speed * Time.deltaTime;
		}
		else if (Input.GetKey (KeyCode.S)||Input.GetAxis("Vertical")<0) {
			transform.position += Vector3.down * m_speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A)||Input.GetAxis("Horizontal")<0) {
			transform.position += Vector3.left * (m_speed + Ambient_scrolling.ambientScrollSpeed) * Time.deltaTime;
		}
		else if (Input.GetKey (KeyCode.D)||Input.GetAxis("Horizontal")>0) {
			transform.position += Vector3.right * m_speed * Time.deltaTime;
		}
		
		transform.position += Vector3.right * Ambient_scrolling.ambientScrollSpeed * Time.deltaTime;

		Debug.Log(held_power_ups.Peek());
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Space)||Input.GetButtonDown("Fire1")) {

			// Instantiate the projectile at the position and rotation of this transform
			Rigidbody2D clone;
			clone = Instantiate(projectile, transform.position + new Vector3(0.5F,0,0), transform.rotation) as Rigidbody2D;
			clone.velocity = transform.TransformDirection(new Vector3(b_speed, 0,0));
		}
	}

	void Activate_Powerups() {
		//Clear power-up stack, determine activated power-up, activate power-up


	}

	// float getX() {
	// 	return transform.position.x;
	// }

	// float getY() {
	// 	return transform.position.y;
	// }


}
