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
       //Modyfikowanie pozycji kamery wzgledem pozycji gracza
        Vector3 playerPositionFromPortal = playerCam.position - portalTwo.position;
        transform.position = portalOne.position + playerPositionFromPortal;
        

        //modyfikowanie rotacji kamery wzgledem rotacji gracza


        float angleRotationDiff = Quaternion.Angle(portalOne.rotation, portalTwo.rotation);

        Quaternion portalRotationDiff = Quaternion.AngleAxis(angleRotationDiff, Vector3.up);

        Vector3 newCamPosition = portalRotationDiff * playerCam.forward;
        transform.rotation = Quaternion.LookRotation(newCamPosition, Vector3.up);


    }



}
