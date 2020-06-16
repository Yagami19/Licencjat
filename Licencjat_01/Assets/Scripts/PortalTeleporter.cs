using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{

    public Transform player;
    public Transform target;


    // Update is called once per frame
    void Update()
    {



        if (playerOverlap)
        {
            Vector3 distance = player.position - transform.position;
            float dotProd = Vector3.Dot(transform.up, distance);


            if (dotProd <0f)
            {
                float rotOffset = -Quaternion.Angle(transform.rotation, target.rotation);
                rotOffset += 180;
                player.Rotate(Vector3.up, rotOffset);

                Vector3 posOffset = Quaternion.Euler(0f, rotOffset, 0f) * distance;
                player.position = target.position + posOffset;

                playerOverlap = false;



            }


        }


    }



    private bool playerOverlap;
    private void OnTriggerEnter(Collider other)
    {
         

        if (other.tag == "Player")
        { 
            playerOverlap = true;
        }
 

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        { 
            playerOverlap = false;
        }

    }



}
 