using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoToGreen : MonoBehaviour
{
    public GameObject GreenPosition;

    public GameObject Player;

    private void Awake()
    {
        if (GreenPosition == null)
        {
            throw new InvalidOperationException("You Did not set green position in inspector");



        }


       
    }




    void OnTriggerEnter(Collider other)
    {

      
        Player.transform.position = GreenPosition.transform.position;

    }




}
