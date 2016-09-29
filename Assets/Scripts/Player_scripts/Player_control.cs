using UnityEngine;
using System;
using System.Collections;

public class Player_control : MonoBehaviour {

	float default_speed;
	public int b_speed = 20;
	public Rigidbody2D projectile;
	public float m_speed;
	public Vector3 pos;
	private bool shield;
	private bool automaticFire = true;

	public Stack held_power_ups = new Stack();
	//array indices: 0=red, 1=blue, 2=yellow
	int[] poweruparray = {0, 0, 0};
	// private int red_state;
	// private int blue_state;
	// private int yellow_state;
	// Use this for initialization
	void Start () {
		default_speed = m_speed;
		shield = false;
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

	}

	void Update() {
		// if (Input.GetKeyDown (KeyCode.Space)||Input.GetButtonDown("Fire1")) {
			FireWeapon();
			if(Input.GetKeyDown(KeyCode.E)||Input.GetButtonDown("GetPower")){
				Activate_Powerups();
			}
			if(Input.GetKeyDown(KeyCode.LeftShift)||Input.GetButtonDown("Special")){

			}
		// 	// Instantiate the projectile at the position and rotation of this transform
		// 	Rigidbody2D clone;
		// 	clone = Instantiate(projectile, transform.position + new Vector3(0.5F,0,0), transform.rotation) as Rigidbody2D;
		// 	clone.velocity = transform.TransformDirection(new Vector3(b_speed, 0,0));
		// 	// ShowPowerUps();
		}
	

	void FireWeapon(){
		if(poweruparray[0]==1){
			if (Input.GetKey(KeyCode.Space)||Input.GetButton("Fire1")) {
				if (automaticFire == true){
					Rigidbody2D clone;
					clone = Instantiate(projectile, transform.position + new Vector3(0.5F,0,0), transform.rotation) as Rigidbody2D;
					clone.velocity = transform.TransformDirection(new Vector3(b_speed, 0,0));
					automaticFire = false;
				}
				else{
					automaticFire = true;
				}
			}
		}
		else{ 
			if (Input.GetKeyDown(KeyCode.Space)||Input.GetButtonDown("Fire1")) {
				Rigidbody2D clone;
				clone = Instantiate(projectile, transform.position + new Vector3(0.5F,0,0), transform.rotation) as Rigidbody2D;
				clone.velocity = transform.TransformDirection(new Vector3(b_speed, 0,0));
			}
		}
	}
	// void ShowPowerUps(){
	// 	held_power_ups.CopyTo(poweruparray, 0);
	// 	for (int i=0; i<3; i++){
	// 		Debug.Log(poweruparray[i]);
	// 	}

	void Activate_Powerups() {
		//array indices: 0=red, 1=blue, 2=yellow
		//Clear power-up stack, determine activated power-up, activate power-up
		// switch(poweruparray){
		// 	case [0, 0, 0]:
		// 		break;
		// 	case [1, 0, 0]:

		// }

		// held_power_ups.CopyTo(poweruparray, 0);

		poweruparray = new int[3];

		// Debug.Log(held_power_ups.Pop());
		for (int i=0; i<held_power_ups.Count; i++){
			char code = (char)held_power_ups.Pop();
			if (code == 'r'){
				poweruparray[0]++;
			}
			else if(code == 'b'){
				poweruparray[1]++;
			}
			else if(code == 'y'){
				poweruparray[2]++;
			}
		}

		for (int i=0; i<3; i++){
			Debug.Log(poweruparray[i]);
		}

		if (poweruparray[2] == 1){
			m_speed=m_speed*1.5f;
		}
		else{
			m_speed=default_speed;
		}

		if (poweruparray[1] == 1){
			shield = true;
		}
		else{
			shield = false;
		}


		// held_power_ups.Clear();

	}

	// float getX() {
	// 	return transform.position.x;
	// }

	// float getY() {
	// 	return transform.position.y;
	// }


}
