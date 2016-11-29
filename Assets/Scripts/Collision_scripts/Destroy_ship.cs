using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.UI;

/****************************************************************************************/
/*
/* FILE NAME: Destroy ship
/*
/* DESCRIPTION: this is the descrution script for the player ship. It first checks if a player
/* is receiving I-frames when it collides with something. If it is, nothing happens. If not,
/* then we check if the ship has a power up ability. If it does, we remove it and give the player
/* I-frames. If it does not, we blow the ship up.
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
 * 11/24/16 Brandon added game over functionality
/* 11/27/16 Jacob   added lives functionality
/*
/****************************************************************************************/

public class Destroy_ship : MonoBehaviour {

	private Player_control pc;
	public Transform explosionPrefab;

	//this detects if the damage object has made contact with the player and
	//it is not experiencing I-frames, if so it deals damage, this results in
	//power up loss or life lost depending if the player has a power up
	void OnCollisionEnter2D(Collision2D col) {
		pc = col.gameObject.GetComponent<Player_control>();
		if (col.gameObject.tag == "Player" && pc.hitframes==false) {
			if(Enumerable.SequenceEqual(pc.poweruparray, new int[3])){
				ContactPoint2D contact = col.contacts[0];
				Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
				Vector3 pos = contact.point;
				Instantiate(explosionPrefab, pos, rot);
				Destroy(col.gameObject);
				StartCoroutine (lifeDown ());
            }
			else{
				pc.LosePowerUp();
			}
		}
	}

	//we repeat the process here in case the object is still in contact after
	//I frames complete
	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "Player" && pc.hitframes==false) {
			ContactPoint2D contact = col.contacts[0];
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			Vector3 pos = contact.point;
			Instantiate(explosionPrefab, pos, rot);
			Destroy(col.gameObject);
			StartCoroutine (lifeDown ());
		}
	}

	//give player a moment to realize they died, then begin process of going back
	//to checkpoint/gameover
	public IEnumerator lifeDown() {
		yield return new WaitForSeconds (1.0f);
		life_counter.decreaseLife ();
	}
}
