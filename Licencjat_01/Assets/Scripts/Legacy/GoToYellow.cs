using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GoToYellow : MonoBehaviour
{

    public GameObject YellowPosition;

    public GameObject Player;

    private void Awake()
    {
        if (YellowPosition == null)
        {
            throw new InvalidOperationException("You Did not set yellow position in inspector");



        }



    }




    void OnTriggerEnter(Collider other)
    {


        Player.transform.position = YellowPosition.transform.position;

    }
}
