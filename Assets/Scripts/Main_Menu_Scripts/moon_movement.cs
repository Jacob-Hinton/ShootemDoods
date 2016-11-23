using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: moon_movement
/*
/* DESCRIPTION: this script controls the slow rising of the moon on the title screen/main menu
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 10/25/16	Jacob	created headr
/*
/*
/****************************************************************************************/

public class moon_movement : MonoBehaviour {

    public float speed;
    public Vector3 pos;
    // Use this for initialization
    void Start () {
        pos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(4,2,0) * speed * Time.deltaTime;
    }
}
