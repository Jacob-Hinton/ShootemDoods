using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: destroyAfterAnim
/*
/* DESCRIPTION: this script destroys an object on completion of an animation
/*
/*
/* DATE       BY     	DESCRIPTION
/* ========   ======= =============
/* 11/18/16	  Brandon	created script
 * 11/18.1/16 Jake      added the HEADER LIKE EVERYONE ELSE DOES
/*
/*
/****************************************************************************************/

public class destroyAfterAnim : MonoBehaviour {
	public float delay = 0f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, this.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0).length + delay);
	}
}
