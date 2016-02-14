using UnityEngine;
using System.Collections;
using System;

public class SelectHairForYryScene : MonoBehaviour {
    public bool isBack = false;
    public bool isContinue = false;
    public bool isRight = false;
    public bool isLeft = false;
    public static bool CCCCChanges;
    Color maincolor;
    Color onMouseEntercolor;
    Color onMouseClickColor;

    public GameObject[] FemaleHairs = new GameObject[5];
    public GameObject[] MaleHairs = new GameObject[4];
    static public int indexTOT = 0;
    // Use this for initialization
    void Start () {
        //Assign the Color
        maincolor = new Color(0f, 0f, 0f, 1f);
        onMouseEntercolor = new Color(0.9607f, 0.6784f, 0.3450f, 1f);
        onMouseClickColor = new Color(0.2f, 0.1882f, 0.1921f, 1f);
        GetComponent<Renderer>().material.color = maincolor;
        //Assign the Arrays Objects
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

        if (CCCCChanges)
        {
            if (StartSceneButton.activeF)
                PositionFemale();
            //FemaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);

            if (StartSceneButton.activeM)
                PositionMale();
            // MaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);

            CCCCChanges = false;
        }
    }

    void PositionFemale()
    {
        FemaleHairs[indexTOT].transform.position = new Vector3(-2499.76f, -515.09f, -8.58f);
    }

    void PositionMale()
    {
        MaleHairs[indexTOT].transform.position = new Vector3(-2499.76f, -515.09f, -8.58f);
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
            if (StartSceneButton.activeF)
                 FemaleHairs[indexTOT].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);

            if (StartSceneButton.activeM)
                MaleHairs[indexTOT].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);

            StartSceneButton.activeM = false;
            StartSceneButton.activeF = false;
            CameraPosition.posCamera = 1;
            GameObject.FindGameObjectWithTag("M").GetComponent<Renderer>().material.color = maincolor;
            GameObject.FindGameObjectWithTag("F").GetComponent<Renderer>().material.color = maincolor;
            indexTOT = 0;

        }
        if (isContinue)
        {
            Application.LoadLevel("SceneTryToYourself");
        }
        if (isRight)
        {
            if (StartSceneButton.activeF)
            {
                if (indexTOT < FemaleHairs.Length - 1)
                {
                    indexTOT++;

                    PositionFemale();

                    FemaleHairs[indexTOT - 1].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);


                }

                else
                {
                    indexTOT = 0;

                    PositionFemale();

                    FemaleHairs[FemaleHairs.Length - 1].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);

                    //FemaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }
            }
            if (StartSceneButton.activeM)
            {
                //Usare MaleHairs.Lenght al posto di 3 (Al momento non funziona)
                if (indexTOT < 3)
                {
                    indexTOT++;

                    PositionMale();

                    MaleHairs[indexTOT - 1].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);

                    //MaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }

                else
                {
                    indexTOT = 0;

                    PositionMale();
                    //Usare MaleHairs.Lenght al posto di 3 (Al momento non funziona)
                    MaleHairs[3].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);

                    // MaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }
            }
        }
        if (isLeft)
        {
            if (StartSceneButton.activeF)
            {
                if (indexTOT == 0)
                {
                    indexTOT = FemaleHairs.Length - 1;
                    PositionFemale();
                    FemaleHairs[0].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);

                    // FemaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }

                else
                {
                    indexTOT--;
                    PositionFemale();
                    FemaleHairs[indexTOT + 1].transform.position = new Vector3(-1047.2f, -515f, -9.193481f);

                    //FemaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }
            }
            if (StartSceneButton.activeM)
            {
                if (indexTOT == 0)
                {
                    indexTOT = 3;
                    PositionMale();

                    //Usare MaleHairs.Lenght al posto di 3 (Al momento non funziona)

                    MaleHairs[0].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);

                    // MaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }

                else
                {
                    indexTOT--;
                    PositionMale();
                    MaleHairs[indexTOT + 1].transform.position = new Vector3(-949.6119f, -515f, -9.166519f);

                    // MaleHairs[index].transform.position = new Vector3(-999.76f, -515.03f, -8.253479f);
                }
            }
        }
        }
    }
