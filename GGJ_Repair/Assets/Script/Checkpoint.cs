﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called before the first frame update
    private Controll controll;
    void Start()
    {
        controll = GameObject.FindGameObjectWithTag("LM").GetComponent<Controll>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
<<<<<<< HEAD
            lm.Position(other);
            Debug.Log("here");
=======
            //controll.Position();
>>>>>>> parent of b9fd01f... find the first and fixed the controller
        }
    }
            // Update is called once per frame
            void Update()
    {
        
    }
}
