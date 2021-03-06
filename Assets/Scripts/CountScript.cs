﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScript : MonoBehaviour {

    int count = 0;

    int[] countFish;

    public Text countScore;

    GameObject fish;
    GameObject crab;

	// Use this for initialization
	void Start () {
        countFish = new int[5];
	}
	
	// Update is called once per frame
	void Update () {

        countScore.text = count.ToString();

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "fish" && collision.GetComponent<Collider2D>().gameObject != fish)
        {
            count++;
            fish = collision.GetComponent<Collider2D>().gameObject;
            if (fish.name == "Fish1L(Clone)" || fish.name == "Fish1R(Clone)")
            {
                countFish[0]++;
            }
            else if (fish.name == "Fish2L(Clone)" || fish.name == "Fish2R(Clone)")
            {
                countFish[1]++;
            }
            else if (fish.name == "Fish3L(Clone)" || fish.name == "Fish3R(Clone)")
            {
                countFish[2]++;
            }
            else if (fish.name == "Fish4L(Clone)" || fish.name == "Fish4R(Clone)")
            {
                countFish[3]++;
            }
            else if (fish.name == "Fish5L(Clone)" || fish.name == "Fish5R(Clone)")
            {
                countFish[4]++;
            }
        }
        if (collision.GetComponent<Collider2D>().tag == "crab" && collision.GetComponent<Collider2D>().gameObject != crab)
        {
            crab = collision.GetComponent<Collider2D>().gameObject;
            if (crab.name == "Crab1(Clone)")
            {
                if (countFish[0] - 10 >= 0)
                {
                    countFish[0] -= 10;
                    count -= 10;
                } else
                {
                    int difference = countFish[0];
                    countFish[0] = 0;
                    if (count - difference >= 0)
                    {
                        count -= difference;
                    } else
                    {
                        count = 0;
                    }
                }
            }
            else if (crab.name == "Crab2(Clone)")
            {
                if (countFish[1] - 10 >= 0)
                {
                    countFish[1] -= 10;
                    count -= 10;
                }
                else
                {
                    int difference = countFish[1];
                    countFish[1] = 0;
                    if (count - difference >= 0)
                    {
                        count -= difference;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            else if (crab.name == "Crab3(Clone)")
            {
                if (countFish[2] - 10 >= 0)
                {
                    countFish[2] -= 10;
                    count -= 10;
                }
                else
                {
                    int difference = countFish[2];
                    countFish[2] = 0;
                    if (count - difference >= 0)
                    {
                        count -= difference;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            else if (crab.name == "Crab4(Clone)")
            {
                if (countFish[3] - 10 >= 0)
                {
                    countFish[3] -= 10;
                    count -= 10;
                }
                else
                {
                    int difference = countFish[3];
                    countFish[3] = 0;
                    if (count - difference >= 0)
                    {
                        count -= difference;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            else if (crab.name == "Crab5(Clone)")
            {
                if (countFish[4] - 10 >= 0)
                {
                    countFish[4] -= 10;
                    count -= 10;
                }
                else
                {
                    int difference = countFish[4];
                    countFish[4] = 0;
                    if (count - difference >= 0)
                    {
                        count -= difference;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "fish" && collision.GetComponent<Collider2D>().gameObject.GetComponent<FishScript>().touchedBait)
        {
            collision.GetComponent<Collider2D>().gameObject.GetComponent<FishScript>().bait.GetComponent<BaitScript>().initialCount++;
            collision.GetComponent<Collider2D>().gameObject.GetComponent<FishScript>().touchedBait = false;
        }
    }
}
