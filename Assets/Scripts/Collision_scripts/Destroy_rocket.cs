using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Destroy rocket
/*
/* DESCRIPTION: this is the descrution script for rocket projectiles, these act like bullets
 * 				except they explode on destruction and their explosion hurts enemies
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 11/18/16 Jacob   created script
/*
/*
/****************************************************************************************/

public class Destroy_rocket : MonoBehaviour {

	public Transform explosionPrefab;


	void OnCollisionEnter2D(Collision2D col) {

			//destroy rocket and spawn a rocket explosion at point of contact
			ContactPoint2D contact = col.contacts[0];
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			Vector3 pos = contact.point;
			Instantiate(explosionPrefab, pos, rot);
			Destroy(gameObject);

	}
}
