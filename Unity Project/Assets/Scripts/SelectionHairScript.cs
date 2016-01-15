using UnityEngine;
using System.Collections;

public class SelectionHairScript : MonoBehaviour {
    Color maincolor;
    Color onMouseEntercolor;
    Color onMouseClickColor;
    public bool isLeft = false;
    public bool isRight = false;
    public bool isBack = false;
    public bool isContinue = false;
    public GameObject[] FemaleHairs = new GameObject[5];
    public GameObject[] MaleHairs = new GameObject[4];
    static public int index = 0;

    // Use this for initialization
    void Start () {
        maincolor = new Color(0f, 0f, 0f, 1f);
        onMouseEntercolor = new Color(0.9607f, 0.6784f, 0.3450f, 1f);
        onMouseClickColor = new Color(0.2f, 0.1882f, 0.1921f, 1f);
        GetComponent<Renderer>().material.color = maincolor;
        
        FemaleHairs[0] = GameObject.FindGameObjectWithTag("FemaleHair1");
        FemaleHairs[1] = GameObject.FindGameObjectWithTag("FemaleHair2");
        FemaleHairs[2] = GameObject.FindGameObjectWithTag("FemaleHair3");
        FemaleHairs[3] = GameObject.FindGameObjectWithTag("FemaleHair4");
        FemaleHairs[4] = GameObject.FindGameObjectWithTag("FemaleHair5");

        MaleHairs[0] = GameObject.FindGameObjectWithTag("MaleHair1");
        MaleHairs[1] = GameObject.FindGameObjectWithTag("MaleHair2");
        MaleHairs[2] = GameObject.FindGameObjectWithTag("MaleHair3");
        MaleHairs[3] = GameObject.FindGameObjectWithTag("MaleHair4");
        
    }
	
	// Update is called once per frame
	void Update () {

        if (ScanSceneButton.changeScene)
        {
            if (ActivateDepth.activeF)
                FemaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);

            if (ActivateDepth.activeM)
                MaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);

            ScanSceneButton.changeScene = false;
        }
    }

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = onMouseEntercolor;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = maincolor;
    }
    void OnMouseUp()
    {
        GetComponent<Renderer>().material.color = onMouseClickColor;

        if (isBack)
        {
            CameraPosition.posCamera = 1;
            ScanSceneButton.back = true;
            ActivateDepth.activeM = false;
            ActivateDepth.activeF = false;
            ActivateDepth.activeD = false;
            GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(948.0611f, -664.79f, -10.73032f); 

            //Automatizzare questi spostamenti         
            MaleHairs[0].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);
            MaleHairs[1].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);
            MaleHairs[2].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);
            MaleHairs[3].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);
                
            FemaleHairs[0].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);
            FemaleHairs[1].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);
            FemaleHairs[2].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);
            FemaleHairs[3].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);
            FemaleHairs[4].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);
            index = 0;
            
        }

        if (isContinue)
        {
            CameraPosition.posCamera = 5;
        }

        if (isRight)
        {
            if (ActivateDepth.activeF)
            {
                if (index < FemaleHairs.Length - 1)
                {
                    index++;
                    FemaleHairs[index - 1].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);

                    FemaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }

                else
                {
                    index = 0;
                    FemaleHairs[FemaleHairs.Length - 1].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);

                    FemaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }
            }
            if (ActivateDepth.activeM)
            {
                //Usare MaleHairs.Lenght al posto di 3 (Al momento non funziona)
                if (index < 3)
                {
                    index++;
                    MaleHairs[index - 1].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);

                    MaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }

                else
                {
                    index = 0;
                    //Usare MaleHairs.Lenght al posto di 3 (Al momento non funziona)
                    MaleHairs[3].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);

                    MaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }
            }
        }
        if (isLeft)
        {
            if (ActivateDepth.activeF)
            {
                if (index == 0)
                {
                    index = FemaleHairs.Length - 1;
                    FemaleHairs[0].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);

                    FemaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }

                else
                {
                    index--;
                    FemaleHairs[index + 1].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);

                    FemaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }
            }
            if (ActivateDepth.activeM)
            {
                if (index == 0)
                {
                    //Usare MaleHairs.Lenght al posto di 3 (Al momento non funziona)
                    index = 3;
                    MaleHairs[0].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);

                    MaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }

                else
                {
                    index--;
                    MaleHairs[index + 1].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);

                    MaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }
            }
        }
        
    }
   
  }

        
