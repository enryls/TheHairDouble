using UnityEngine;
using System.Collections;

public class WallPapersSelection : MonoBehaviour
{
    Color maincolor;
    Color onMouseEntercolor;
    Color onMouseClickColor;
    public bool isLeft = false;
    public bool isRight = false;
    public bool isBack = false;
    public GameObject[] WallPapers = new GameObject[8];
    static public int index = 0;

    // Use this for initialization
    void Start()
    {
        //assign the color of the buttons
        maincolor = new Color(0f, 0f, 0f, 1f);
        onMouseEntercolor = new Color(0.9607f, 0.6784f, 0.3450f, 1f);
        onMouseClickColor = new Color(0.2f, 0.1882f, 0.1921f, 1f);
        GetComponent<Renderer>().material.color = maincolor;

        //assign the Wallpapers to Array
        WallPapers[0] = GameObject.FindGameObjectWithTag("1");
        WallPapers[1] = GameObject.FindGameObjectWithTag("2");
        WallPapers[2] = GameObject.FindGameObjectWithTag("3");
        WallPapers[3] = GameObject.FindGameObjectWithTag("4");
        WallPapers[4] = GameObject.FindGameObjectWithTag("5");
        WallPapers[5] = GameObject.FindGameObjectWithTag("6");
        WallPapers[6] = GameObject.FindGameObjectWithTag("7");
        WallPapers[7] = GameObject.FindGameObjectWithTag("8");
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
        
        if (isBack)
        {
            //If Click on Back
            ScanSceneButton.changeScene = true;
            CameraPosition.posCamera = 3;
            if (ScanSceneButton.activeD)
                GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(-1005.3f, -501.4f, -14.8f);

            if (StartSceneButton.activeF)
            {
                GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(-999.25f, -506.84f, -6.53f);
            }

            if (StartSceneButton.activeM)
            {
                GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(-999.85f, -506.49f, -6.6f);
            }

        }
       
        if (isRight)
        {
            //if Click Right Arrow runs the array to the right
            if (index < WallPapers.Length - 1)
            {   
                
                index++;
                WallPapers[index - 1].transform.position = new Vector3(0f, 500f, 0f);

                WallPapers[index].transform.position = new Vector3(0.3f, -500f, -9f);
            }

            else
            {
                //index point on the last object of the array
                index = 0;
                WallPapers[WallPapers.Length - 1].transform.position = new Vector3(0f, 500f, 0f);

                WallPapers[index].transform.position = new Vector3(0.3f, -500f, -9f);
            }
        }

        if (isLeft)
        {
            //if Click Left Arrow runs the array to the left
            if (index == 0)
            {
                //index point on the first object of the array
                index = WallPapers.Length - 1;
                WallPapers[0].transform.position = new Vector3(0f, 500f, 0f);

                WallPapers[index].transform.position = new Vector3(0.3f, -500f, -9f);
            }

            else
            {
                index--;
                WallPapers[index + 1].transform.position = new Vector3(0f, 500f, 0f);

                WallPapers[index].transform.position = new Vector3(0.3f, -500f, -9f);
            }
        }
    }
}