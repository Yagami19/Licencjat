﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRedToYellow : MonoBehaviour
{
    public Transform playerCamera;
    public Transform Portal;
    public Transform otherPortal;



    // Update is called once per frame
    void Update()

    {

        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
        transform.position = Portal.position + playerOffsetFromPortal;

        float angularDifferenceBetweenPortalRotations = Quaternion.Angle(Portal.rotation, otherPortal.rotation);



        Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);

        Vector3 newCameraDirection = portalRotationalDifference * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);





    }



}
