using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Enemy_square
/*
/* DESCRIPTION: this script has enemies travel in a square around the sreen
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 11/25/16	Jacob	created script
/*
/*
/****************************************************************************************/

public class Enemy_square : MonoBehaviour
{
    int side = 0;
    public float speed;
    public float sideSize = 1.0F;
    public Vector3 pos;
    public bool coRoutineStarted = false;
    // Use this for initialization
    void Start()
    {
        pos = transform.position;
    }

    // FixedUpdate called at regular intervals
    void FixedUpdate()
    {

        //checks if the enemy is on the screen before executing their movement path
        if (GetComponent<Renderer>().isVisible)
            
        {
            transform.position += Vector3.right * (Ambient_scrolling.ambientScrollSpeed) * Time.deltaTime;
            //enemy movement path
            if (side == 0)
            {
                transform.position += Vector3.left * (speed + Ambient_scrolling.ambientScrollSpeed) * Time.deltaTime;
                if (!coRoutineStarted)
                {
                    StartCoroutine(changeSide());
                }
            }
            else if (side == 1)
            {
                transform.position += Vector3.down * (Ambient_scrolling.ambientScrollSpeed) * Time.deltaTime;
                //transform.position += Vector3.right * (speed- Ambient_scrolling.ambientScrollSpeed) * Time.deltaTime;
                //transform.position += Vector3.right * ( Ambient_scrolling.ambientScrollSpeed) * Time.deltaTime;
                if (!coRoutineStarted)
                {
                    StartCoroutine(changeSide());
                }
            }
            else if (side == 2)
            {
                transform.position += Vector3.right * (Ambient_scrolling.ambientScrollSpeed) * Time.deltaTime;
                if (!coRoutineStarted)
                {
                    StartCoroutine(changeSide());
                }
            }
            else if (side == 3)
            {
                transform.position += Vector3.up * (speed+ Ambient_scrolling.ambientScrollSpeed) * Time.deltaTime;
               // transform.position += Vector3.right * (speed Ambient_scrolling.ambientScrollSpeed) * Time.deltaTime;
                if (!coRoutineStarted)
                {
                    StartCoroutine(changeSide());
                }
            }
        }
    }

    public IEnumerator changeSide()
    {
        coRoutineStarted = true;

        if (side == 0 || side == 2) { 
            yield return new WaitForSeconds(sideSize);
        }
        else
        {
            yield return new WaitForSeconds(sideSize*2/3);
        }
        side++;
        if (side > 3)
        {
            side = 0;
        }

        coRoutineStarted = false;
    }


}