using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSizeSetup : MonoBehaviour
{
    public Camera cameraYellow;
    public Material cameraMatYellow;

    public Camera cameraRed;
    public Material cameraMatRed;

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
    }
}









