using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Within_bounds
/*
/* DESCRIPTION: this script checks if an object is within bounds, if not it is destroyed
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
/*
/*
/****************************************************************************************/

public class Within_bounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Late Update is called once per frame at the end
	void Update () {
		if (!GetComponent<Renderer>().isVisible)
			Destroy (this.gameObject);
	}
}
