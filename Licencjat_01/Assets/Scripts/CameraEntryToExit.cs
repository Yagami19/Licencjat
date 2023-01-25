using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEntryToExit: MonoBehaviour
{
    public Transform playerCam;
    public Transform portalOne;
    public Transform portalTwo;
  
    void Update()
    {
       //Modification of camera's position based on player's position
        Vector3 playerPositionFromPortal = playerCam.position - portalTwo.position;
        transform.position = portalOne.position + playerPositionFromPortal;

        //Modification of camera's rotation based on player's rotation
        float angleRotationDiff = Quaternion.Angle(portalOne.rotation, portalTwo.rotation);
        Quaternion portalRotationDiff = Quaternion.AngleAxis(angleRotationDiff, Vector3.up);
        Vector3 newCamPosition = portalRotationDiff * playerCam.forward;
        transform.rotation = Quaternion.LookRotation(newCamPosition, Vector3.up);
    }
}


