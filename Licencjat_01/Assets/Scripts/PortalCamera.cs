﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCam;
    public Transform portalOne;
    public Transform portalTwo;

    void Update()
    {
        Vector3 playerPositionFromPortal = playerCam.position - portalTwo.position;
        transform.position = portalOne.position + playerPositionFromPortal;
    }
}


















