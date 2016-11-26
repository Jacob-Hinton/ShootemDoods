using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Enemy_Sin
/*
/* DESCRIPTION: this script has enemies travel in a sin wave motion across the screen
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 11/25/16	Brandon	created script
/*
/*
/****************************************************************************************/

public class Enemy_Sin : MonoBehaviour
{

    public float MoveSpeed = 0.1f;

    public float frequency = 0.1f;  // Speed of sine movement
    public float magnitude = 10.0f;   // Size of sine movement
    private Vector3 axis;

    private Vector3 pos;
    // Use this for initialization
    void Start()
    {
        pos = transform.position;
        //DestroyObject(gameObject, 1.0f);
        axis = transform.up;  // May or may not be the axis you want
    }

    // FixedUpdate called at regular intervals
    void FixedUpdate()
    {

        //checks if the enemy is on the screen before executing their movement path
        if (GetComponent<Renderer>().isVisible)
        {
            pos -= transform.right * Time.deltaTime * MoveSpeed;
            transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
        }
    }

    float getX()
    {
        return transform.position.x;
    }

    float getY()
    {
        return transform.position.y;
    }


}