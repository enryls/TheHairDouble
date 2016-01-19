using UnityEngine;
using System.Collections;

public class ScanSceneButton : MonoBehaviour
{

    public bool isScan = false;
    public bool isBack = false;
    public bool isContinue = false;
    public static bool changeScene;
    public static bool scan;
    public static bool back;
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
            ChangeTheDamnSprite();
            scan = true;
            ActivateDepth.activeD = true;

        }
        if (isBack)
        {
            CameraPosition.posCamera = 1;
            back = true;
            ActivateDepth.activeM = false;
            ActivateDepth.activeF = false;
            ActivateDepth.activeD = false;
        }
        
        if (isContinue)
        {
            CameraPosition.posCamera = 4;
            changeScene = true;
            if (ActivateDepth.activeD)
            {
                GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(-1005.3f, -501.4f, -14.8f);
                ActivateDepth.activeD = false;
            }
            /*if (GameObject.FindGameObjectWithTag("woman").transform.position == new Vector3(999.88f, -675.04f, -3.43f))
            {
                GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(-999.25f, -506.84f, -6.53f);
               //ActivateDepth.activeF = false;
            }
            if (GameObject.FindGameObjectWithTag("man").transform.position == new Vector3(999.28f, -674.69f, -3.5f))
            {
                GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(-999.55f, -506.49f, -6.6f);
               //ActivateDepth.activeM = false;
            }*/
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