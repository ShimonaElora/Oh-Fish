﻿using UnityEngine;
using UnityEngine.UI;

public class FishScript : MonoBehaviour {
    
    public bool touchedBait = false;
    public GameObject bait;
    public bool collided = false;
    public bool inverted;
    public Text text;
    bool countMarkerTouched = false;

	// Use this for initialization
	void Start () {
        touchedBait = false;
        GetComponent<Collider2D>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (GameoverScript.gameover)
        {
            GetComponent<Collider2D>().enabled = false;
        }
        if (touchedBait)
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), GameObject.FindGameObjectWithTag("bait").GetComponent<Collider2D>());
        }
        if (countMarkerTouched)
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), GameObject.Find("countMarker").GetComponent<Collider2D>());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "bullet")
        {
            collided = true;
            if (transform.position.y <= -1.5f)
            {
                if (inverted)
                {
                    if (transform.rotation.z >= 0f) text.text = "Critical Catch";
                    else text.text = "Early Catch";
                } else
                {
                    if (transform.rotation.z >= 0f) text.text = "Early Catch";
                    else text.text = "Critical Catch";
                }
            }
        }

        if (collision.collider.gameObject.name == "countMarker")
        {
            countMarkerTouched = true;
        }
    }

}
