using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Destroy_shield
/*
/* DESCRIPTION: this is the descrution script for the shield powerup. The shield
 * is destroyed upon colliding with a damaging object unless that object is a bullet 
 * fired by an enemy.
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
 *          Jacob   created script
/* 11/25/16 Brandon added header
/*
/*
/****************************************************************************************/

public class Destroy_shield : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col) {

		ContactPoint2D contact = col.contacts[0];
		Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
		Vector3 pos = contact.point;
        if (!col.gameObject.CompareTag("enemy_bullet"))
        {
            Destroy(gameObject);
        }
	}
}
