using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSizeSetup : MonoBehaviour
{
    public Camera cameraYellow;
    public Material cameraMatYellow;

    public Camera cameraRed;
    public Material cameraMatRed;

    public Camera cameraRed2;
    public Material cameraMatRed2;

    public Camera cameraYellow2;
    public Material cameraMatYellow2;

    //variables yellow to yellow roundabout
    public Camera cameraYRoundaboutEntry;
    public Material cameraMatYRoundaboutEntry;

    public Camera cameraYRoundaboutExit;
    public Material cameraMatYRoundaboutExit;

    //variables yellow rounabout to green
    public Camera cameraYRoundaboutToGreenEntry;
    public Material cameraMatYRoundaboutToGreenEntry;

    public Camera cameraYRoundaboutToGreenExit;
    public Material cameraMatYRoundaboutToGreenExit;

    //vars green to green roundabout
    public Camera cameraGToRoundaboutEntry;
    public Material cameraMatGToRoundaboutEntry;

    public Camera cameraGToRoundaboutExit;
    public Material cameraMatGToRoundaboutExit;

    //VARIABLES green roundabout TO red room
    public Camera cameraGRoundaboutToRedEntry;
    public Material cameraMatGRoundaboutToRedEntry;

    public Camera cameraGRoundaboutToRedExit;
    public Material cameraMatGRoundaboutToRedExit;

    void Start()
    {
        //Setting Yellow and Red cameras
        if (cameraYellow.targetTexture != null)
        {
            cameraYellow.targetTexture.Release();
        }

        cameraYellow.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatYellow.mainTexture = cameraYellow.targetTexture;

        if (cameraRed.targetTexture != null)
        {
            cameraRed.targetTexture.Release();
        }

        cameraRed.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatRed.mainTexture = cameraRed.targetTexture;

        if (cameraRed2.targetTexture != null)
        {
            cameraRed2.targetTexture.Release();
        }

        cameraRed2.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatRed2.mainTexture = cameraRed2.targetTexture;
        if (cameraYellow2.targetTexture != null)
        {
            cameraYellow2.targetTexture.Release();
        }

        cameraYellow2.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatYellow2.mainTexture = cameraYellow2.targetTexture;

        //SETTING YELLOW TO ROUNDABOUT CAMERAS
        if (cameraYRoundaboutEntry.targetTexture != null)
        {
            cameraYRoundaboutEntry.targetTexture.Release();
        }

        cameraYRoundaboutEntry.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatYRoundaboutEntry.mainTexture = cameraYRoundaboutEntry.targetTexture;

        if (cameraYRoundaboutExit.targetTexture != null)
        {
            cameraYRoundaboutExit.targetTexture.Release();
        }

        cameraYRoundaboutExit.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatYRoundaboutExit.mainTexture = cameraYRoundaboutExit.targetTexture;

        //SETTING YELLOW TO GREEN CAMERAS
        if (cameraYRoundaboutToGreenEntry.targetTexture != null)
        {
            cameraYRoundaboutToGreenEntry.targetTexture.Release();
        }

        cameraYRoundaboutToGreenEntry.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatYRoundaboutToGreenEntry.mainTexture = cameraYRoundaboutToGreenEntry.targetTexture;
        if (cameraYRoundaboutToGreenExit.targetTexture != null)
        {
            cameraYRoundaboutToGreenExit.targetTexture.Release();

        }
        cameraYRoundaboutToGreenExit.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatYRoundaboutToGreenExit.mainTexture = cameraYRoundaboutToGreenExit.targetTexture;

        //SETTING GREEN TO ROUNDABOUT CAMERAS
        if (cameraGToRoundaboutEntry.targetTexture != null)
        {
            cameraGToRoundaboutEntry.targetTexture.Release();
        }

        cameraGToRoundaboutEntry.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatGToRoundaboutEntry.mainTexture = cameraGToRoundaboutEntry.targetTexture;
        if (cameraGToRoundaboutExit.targetTexture != null)
        {
            cameraGToRoundaboutExit.targetTexture.Release();
        }

        cameraGToRoundaboutExit.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatGToRoundaboutExit.mainTexture = cameraGToRoundaboutExit.targetTexture;


        //Setting Green roundabout to red room
        if (cameraGRoundaboutToRedEntry.targetTexture != null)
        {
            cameraGRoundaboutToRedEntry.targetTexture.Release();
        }

        cameraGRoundaboutToRedEntry.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatGRoundaboutToRedEntry.mainTexture = cameraGRoundaboutToRedEntry.targetTexture;
        if (cameraGRoundaboutToRedExit.targetTexture != null)
        {
            cameraGRoundaboutToRedExit.targetTexture.Release();
        }
        cameraGRoundaboutToRedExit.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatGRoundaboutToRedExit.mainTexture = cameraGRoundaboutToRedExit.targetTexture;
    }

}









