using UnityEngine;
using System;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Player_control
/*
/* DESCRIPTION: this script contains all the default player controls as well as the pwr
/* 		up implementation.
/*
/*
/* DATE     BY     			  DESCRIPTION
/* ======== ======= 		  =============
/* 10/25/16 Jacob		      created headr
/* 11/15/16 Jacob/Brandon     edited movement/machine gun pwrup
 * 11/18/16 Brandon/Jacob     added ship movement animation
 * 						      added rocket pwrup
 * 11/24/16 Brandon           switch special to B button (joystick 1)
 * 11/25/16 Brandon           balanced machine gun and default gun by adding default gun delay, also decreased default speed.
 *                            For additional balance, added some i frames to the blink, blink only teleports certain distance to the right
 *                            For even MORE balance, switched out the missile and laZer in the power-up chain (ie 2 reds now = laZer)
 *                           
/*
/****************************************************************************************/

public class Player_control : MonoBehaviour {
	private SpriteRenderer sRenderer;
	float default_speed = 2;
	public int b_speed = 20;
	public int charge_speed = 2;
	public float teleportDistance = 80;
	private float ambientSpeed = Ambient_scrolling.ambientScrollSpeed;
	public Rigidbody2D projectile;
	public Rigidbody2D laZer;
	public Rigidbody2D rocket;
	public Rigidbody2D shockwave;
	public Rigidbody2D shield;
	public Animator playeranimator;
	public float m_speed;
	public Vector3 pos;
	public cooldownbar_script cooldownbool;
	private bool automaticFire = true;
	private bool coRoutineIsStarted = false;
	public float invuln_timer = 0;
	public bool hitframes = false;
	public System.Random rand = new System.Random ();

	public Sprite down;
	public Sprite idle;
	public Sprite up;


	public Stack held_power_ups = new Stack();
	//array indices: 0=red, 1=blue, 2=yellow
	public int[] poweruparray = {0, 0, 0};

	// Use this for initialization
	void Start () {
		playeranimator = GetComponent<Animator> ();

		sRenderer = GetComponent<SpriteRenderer> ();
		cooldownbool = GameObject.FindWithTag("cooldown_bar").GetComponent<cooldownbar_script>();
		this.gameObject.layer = 9;
		default_speed = m_speed;
		pos = transform.position;
		GameObject theCamera = GameObject.Find("Camera");
		pause_script pauseScript = theCamera.GetComponent<pause_script>();

	}
	
	// FixedUpdate called at regular intervals
	void FixedUpdate () {
		//ship movement
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
		transform.position += move * m_speed * Time.deltaTime;

		//check for invulnerability
		if (invuln_timer>0){
			invuln_timer -= 1f*Time.deltaTime;
			if(invuln_timer<=0) {
				this.gameObject.layer = 9;
				hitframes = false;
				this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
			}
		}


		//ambient movement		
		transform.position += Vector3.right * ambientSpeed * Time.deltaTime;


			//up-down animation
		if (move.y < 0) {
            playeranimator.SetTrigger("flyDown");
        } else if (move.y > 0) {
            playeranimator.SetTrigger("flyUp");
        } else {
            playeranimator.SetTrigger("idle");
        }

	}

	void Update() {

		if (!pause_script.isPause) {
			FireWeapon ();
			if (Input.GetKeyDown (KeyCode.E) || Input.GetButtonDown ("GetPower")) {
				ActivatePowerups ();
			}
			if (Input.GetKeyDown (KeyCode.LeftShift) || Input.GetButtonDown ("Special")) {
				UseAbility ();
			}
		}
	}
	

	void FireWeapon(){
		//machine gun
		if(poweruparray[0]==1){
			if (Input.GetKey (KeyCode.Space) || Input.GetButton ("Fire1")) {
				//StartCoroutine (AutoFire());
				if (automaticFire) {
					Rigidbody2D clone;
					clone = Instantiate (projectile, transform.position + new Vector3 (0.8F, 0, 0), transform.rotation) as Rigidbody2D;
					clone.velocity = transform.TransformDirection (new Vector3 (b_speed, 3 * (float)(rand.NextDouble () - 0.5), 0));
					automaticFire = false;
				} else if(!coRoutineIsStarted){
					StartCoroutine (AutoFire());
				}
			}
		}
        else if (poweruparray[0] == 2)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
            {
                Rigidbody2D clone;
                clone = Instantiate(laZer, transform.position + new Vector3(0.8F, 0, 0), transform.rotation) as Rigidbody2D;
                clone.velocity = transform.TransformDirection(new Vector3(b_speed, 0, 0));
            }
        }
        //rocket
        else if(poweruparray[0] == 3){ 
			if (Input.GetKeyDown(KeyCode.Space)||Input.GetButtonDown("Fire1")) {
				Rigidbody2D clone;
				clone = Instantiate(rocket, transform.position + new Vector3(0.8F,0,0), transform.rotation) as Rigidbody2D;
				clone.velocity = transform.TransformDirection(new Vector3(b_speed, 0,0));
			}	
		}
		//laZer

		//default
		else{ 
			if (Input.GetKeyDown(KeyCode.Space)||Input.GetButtonDown("Fire1")) {
                if (automaticFire)
                {
                    Rigidbody2D clone;
                    clone = Instantiate(projectile, transform.position + new Vector3(0.8F, 0, 0), transform.rotation) as Rigidbody2D;
                    clone.velocity = transform.TransformDirection(new Vector3(b_speed, 0, 0));
                    automaticFire = false;
                }
                else if (!coRoutineIsStarted)
                {
                    StartCoroutine(regFire());
                }
            }
            
        }
	}

	void UseAbility(){
		//Barrel Roll
		if(poweruparray[1] == 2){
			if (cooldownbool.cooldowncomplete) {
				cooldownbool.cooldowncomplete = false;
				invuln_timer = 1;
				playeranimator.SetTrigger ("barrel_roll");
				this.gameObject.layer = 10;
			}
		}
		//shockwave
		else if(poweruparray[1] == 3){
			if (cooldownbool.cooldowncomplete) {
				cooldownbool.cooldowncomplete = false;
				Rigidbody2D clone;
				clone = Instantiate (shockwave, transform.position, transform.rotation) as Rigidbody2D;
				clone.transform.parent = this.transform;
			}
		}
		//blink
		else if(poweruparray[2] == 2){
			if (cooldownbool.cooldowncomplete) {
				cooldownbool.cooldowncomplete = false;
				playeranimator.SetTrigger ("teleport");
                invuln_timer = 1f;
                this.gameObject.layer = 10;
                //var move = new Vector3(Input.GetAxis("Horizontal") * teleportDistance, Input.GetAxis("Vertical") * teleportDistance,0);
                var move = new Vector3(teleportDistance,0, 0);
                transform.position += move * m_speed * Time.deltaTime;
                
                this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
            }
		} 
		//charge attack
		else if(poweruparray[2] == 3){
			if (cooldownbool.cooldowncomplete) {
				cooldownbool.cooldowncomplete = false;
				playeranimator.SetTrigger ("charge");
				ambientSpeed += charge_speed;
				this.gameObject.tag = "player_bullet";
				StartCoroutine (chargeTime());

			}
		}

		//shield
		if (poweruparray [1] == 1) {
			if (cooldownbool.cooldowncomplete) {
				cooldownbool.cooldowncomplete = false;
				Rigidbody2D clone;
				clone = Instantiate (shield, transform.position, transform.rotation) as Rigidbody2D;
				clone.transform.parent = this.transform;			
			}
		}
	}

	public void LosePowerUp(){
		// Getting hit with a power-up
		poweruparray = new int[3];
		invuln_timer = 3;
		hitframes = true;
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0.5f, 0.5f, 0.8f);
		this.gameObject.layer = 10;
		m_speed=default_speed;
	}

	void ActivatePowerups() {
		// Cashing in

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
		while (held_power_ups.Count>0){
			char code = (char)held_power_ups.Pop();
			Debug.Log(code);
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

		//speed up
		if (poweruparray[2] == 1){
			m_speed=m_speed+1.5f;
		}
		else{
			m_speed=default_speed;
		}




		// held_power_ups.Clear();

	}

	// float getX() {
	// 	return transform.position.x;
	// }

	// float getY() {
	// 	return transform.position.y;
	// }

	public IEnumerator AutoFire() {
		coRoutineIsStarted = true;
		automaticFire = false;
		yield return new WaitForSeconds (.15f);
		automaticFire = true;
		coRoutineIsStarted = false;
	}
    public IEnumerator regFire()
    {
        coRoutineIsStarted = true;
        automaticFire = false;
        yield return new WaitForSeconds(.15f);
        automaticFire = true;
        coRoutineIsStarted = false;
    }

    public IEnumerator chargeTime() {
		yield return new WaitForSeconds (.1f);
		ambientSpeed -= charge_speed;
		this.gameObject.tag = "Player";
	}
}
