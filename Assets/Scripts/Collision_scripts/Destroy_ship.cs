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
/*
/*
/****************************************************************************************/

public class Destroy_ship : MonoBehaviour {

	private Player_control pc;
	public Transform explosionPrefab;

	void OnCollisionEnter2D(Collision2D col) {
		pc = col.gameObject.GetComponent<Player_control>();
		if (col.gameObject.tag == "Player" && pc.hitframes==false) {
			if(Enumerable.SequenceEqual(pc.poweruparray, new int[3])){
				ContactPoint2D contact = col.contacts[0];
				Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
				Vector3 pos = contact.point;
				Instantiate(explosionPrefab, pos, rot);
				Destroy(col.gameObject);
                StartCoroutine(showGameOver());
            }
			else{
				pc.LosePowerUp();
			}
		}
	}
	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "Player" && pc.hitframes==false) {
			ContactPoint2D contact = col.contacts[0];
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			Vector3 pos = contact.point;
			Instantiate(explosionPrefab, pos, rot);
			Destroy(col.gameObject);
            StartCoroutine(showGameOver());
		}
	}

    public IEnumerator showGameOver()
    {
        yield return new WaitForSeconds(1.0f);
        pause_script.Pause();
        pause_script.gameOver();


    }
}
