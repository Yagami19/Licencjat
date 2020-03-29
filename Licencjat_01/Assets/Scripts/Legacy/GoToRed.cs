using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoToRed: MonoBehaviour
{
    public GameObject RedPosition;

    public GameObject Player;

    private void Awake()
    {
        if (RedPosition == null)
        {
            throw new InvalidOperationException("You Did not set red position in inspector");



        }



    }




    void OnTriggerEnter(Collider other)
    {


        Player.transform.position = RedPosition.transform.position;

    }
}
