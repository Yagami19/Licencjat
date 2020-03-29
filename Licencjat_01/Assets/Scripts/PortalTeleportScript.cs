using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleportScript : MonoBehaviour
{

    public Transform player;
    public Transform reciever;


    // Update is called once per frame
    void Update()
    {



        if (playerOverlap)
        {
            Vector3 portalToPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);


            if (dotProduct <0f)
            {
                float rotationDiff = -Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.position = reciever.position + positionOffset;

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
 