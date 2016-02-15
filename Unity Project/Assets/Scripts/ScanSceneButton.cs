using UnityEngine;
using System.Collections;

public class ScanSceneButton : MonoBehaviour
{

    public bool isScan = false;
    public bool isBack = false;
    public bool isContinue = false;
    public static bool changeScene;
    public static bool scan;
    public static bool activeD;
    Color maincolor;
    Color onMouseEntercolor;
    Color onMouseClickColor;
    public Sprite ScanSprite;
    public Sprite TryAgainSprite;
    SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        maincolor = new Color(0f, 0f, 0f, 1f);
        onMouseEntercolor = new Color(0.9607f, 0.6784f, 0.3450f, 1f);
        onMouseClickColor = new Color(0.2f, 0.1882f, 0.1921f, 1f);
        GetComponent<Renderer>().material.color = maincolor;
        scan = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnMouseEnter()
    {
        //Color of the Buttons on Mouse Enter
        GetComponent<Renderer>().material.color = onMouseEntercolor;
    }

    void OnMouseExit()
    {
        //Color of the buttons on Mouse Exit return to main color
        GetComponent<Renderer>().material.color = maincolor;
    }
    void OnMouseUp()
    {
        //Color of the buttons on Mouse Up
        GetComponent<Renderer>().material.color = onMouseClickColor;

        
        if (isScan)
        {
            //Active The Scan Object in the Scene
            ChangeTheDamnSprite();
            scan = true;
            activeD = true;
            GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(994.66f, -669.8f, -12.7f);

        }
        if (isBack)
        {
            //Return to The Main Scene and restore the object
            CameraPosition.posCamera = 1;
            StartSceneButton.activeM = false;
            StartSceneButton.activeF = false;
            activeD = false;
            GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(947.5f, -668.01f, -11.1826f);
            GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(944.7f, -682.9f, -4.020004f);
            GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(945.3f, -683.2f, -4.932602f);
            GameObject.FindGameObjectWithTag("M").GetComponent<Renderer>().material.color = maincolor;
            GameObject.FindGameObjectWithTag("F").GetComponent<Renderer>().material.color = maincolor;
        }
        
        if (isContinue)
        {
            //Go to the Next Scene and move the object
            CameraPosition.posCamera = 3;
            changeScene = true;

            
            if (activeD)
            {
                GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(-1004.4f, -501.5f, -14.52f);
                
            }
            if (StartSceneButton.activeF)
            {
                GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(-1000.46f, -509.4f, -13.85f);
            }
            if (StartSceneButton.activeM)
            {
                GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(-1000.15f, -509.54f, -11.93f);
            }
        }

        
          
    }

    //Change The Scan/Try Again Sprite Dinamically
    void ChangeTheDamnSprite()
    {    
        if(spriteRenderer.sprite == TryAgainSprite)
        {
            spriteRenderer.sprite = ScanSprite;
        }
                
        else if (spriteRenderer.sprite == ScanSprite) 
        {
            spriteRenderer.sprite = TryAgainSprite;
        }
        else
        {
            spriteRenderer.sprite = ScanSprite; 
        }
    }
}