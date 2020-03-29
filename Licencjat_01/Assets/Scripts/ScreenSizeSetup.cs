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


    // Start is called before the first frame update
    void Start()
    {
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


        //
        if (cameraRed2.targetTexture != null)
        {
            cameraRed2.targetTexture.Release();


        }

        cameraRed2.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatRed2.mainTexture = cameraRed2.targetTexture;
        //

        if (cameraYellow2.targetTexture != null)
        {
            cameraYellow2.targetTexture.Release();


        }

        cameraYellow2.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatYellow2.mainTexture = cameraYellow2.targetTexture;


        //
    }








}
