using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Destroy laZer
/*
/* DESCRIPTION: this is the descrution script for laZer projectiles that is essentially
/* 		identical to destroy bullet except it is not stopped by enemies.
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
/*
/*
/****************************************************************************************/

public class Destroy_laZer : MonoBehaviour {

	public Transform explosionPrefab;
	public Rigidbody2D currentrigid;
	private int b_speed = 20;

	void Start() {
		currentrigid = this.GetComponent<Rigidbody2D> ();

	}
	void OnCollisionEnter2D(Collision2D col) {

        if (col.gameObject.tag == "terrain"|| col.gameObject.tag == "blocks_lazer")
        {
            Destroy(gameObject);
        }

        currentrigid.velocity = transform.TransformDirection(new Vector3(b_speed, 0,0));
			ContactPoint2D contact = col.contacts[0];
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			Vector3 pos = contact.point;

			
	}
}
