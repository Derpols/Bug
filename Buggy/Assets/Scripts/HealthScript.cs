using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    /*public float health = 100;
    public Text healthCountText;
    int damage = 10;
    public GameObject player;

    Look _look;

    // Start is called before the first frame update

    public void Start()
    {
        
        Look _look = player.GetComponent<Look>(); // Finds the health script attached to the player's gameobject.
        //string minutes = ((int)t / 60).ToString(); // Seconds divided by 60 minus decimals.
        //string seconds = (t % 60).ToString("f0");

        //healthText.text = health + "%"; // Adds health of player.   
    }
    public void HealthLoss(float damage) 
    {
        health -= damage;
        Debug.Log("Deduct health count");
    }

    void Update()
    {
        healthCountText.text = "Health:" + health.ToString();
       
        if (health < 0) 
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
            _look.Death(); // Enables the Re-Use of the Mouse Cursor after the player's death.
        }
    }

    /*void PlayerDeath() 
    {
        if (health < 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
            _look.Death(); // Enables the Re-Use of the Mouse Cursor after the player's death.
        }
    }
    */
}
