using UnityEngine;
using System.Collections;
/****************************************************************************************/
/*
/* FILE NAME: Destroy after lifetime
/*
/* DESCRIPTION: this script deletes bullets after their lifespan has passed. (this may not do anything anymore!!!)
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
/*
/*
/****************************************************************************************/
public class Destroy_after_lifetime : MonoBehaviour {
	public float lifetime;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifetime);
	}

	// Update is called once per frame
	void Update () {
		Destroy (gameObject, lifetime);
	}
}
