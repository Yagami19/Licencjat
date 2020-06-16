using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabScript : MonoBehaviour
{
    //VARIABLES X TO Y
    public Camera XXXXCAMERA;
    public Material XXXMATERIAL;


    public Camera YYYCAMERA;
    public Material YYYMATERIAL;

    //






    // Start is called before the first frame update
    void Start()
    {



        //SETTING GREEN CAMERAS
        if (XXXXCAMERA.targetTexture != null)
        {
            XXXXCAMERA.targetTexture.Release();


        }

        XXXXCAMERA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        XXXMATERIAL.mainTexture = XXXXCAMERA.targetTexture;






        if (YYYCAMERA.targetTexture != null)
        {
            YYYCAMERA.targetTexture.Release();


        }

        YYYCAMERA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        YYYMATERIAL.mainTexture = YYYCAMERA.targetTexture;



        //


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
