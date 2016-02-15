using UnityEngine;
using System.Collections;

public class TryOnYourSelfCO : MonoBehaviour {

    public bool isBack = false;
    public bool isContinue = false;
    Color maincolor;
    Color onMouseEntercolor;
    Color onMouseClickColor;

    public GameObject[] FemaleHairs = new GameObject[5];
    public GameObject[] MaleHairs = new GameObject[4];


    // Use this for initialization
    void Start()
    {
        //Assign the Color
        maincolor = new Color(0f, 0f, 0f, 1f);
        onMouseEntercolor = new Color(0.9607f, 0.6784f, 0.3450f, 1f);
        onMouseClickColor = new Color(0.2f, 0.1882f, 0.1921f, 1f);
        GetComponent<Renderer>().material.color = maincolor;
        //Assign the Arrays Objects
        AssignObject();

        //Enable the Sex choosen
        if (StartSceneButton.activeF)
            ActiveFemale();
        

        if (StartSceneButton.activeM)
            ActiveMale();
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
            
            CameraPosition.posCamera = 5;
            SelectHairForYryScene.CCCCChanges = true;
            Application.LoadLevel("MainScene");
        }

        
        if (isContinue)
        {
            Application.LoadLevel("SceneBackGround");
        }
    }

    void ActiveFemale()
    {
        FemaleHairs[SelectHairForYryScene.indexTOT].GetComponent<ModelHatController>().enabled = true;
    }

    void ActiveMale()
    {
        MaleHairs[SelectHairForYryScene.indexTOT].GetComponent<ModelHatController>().enabled = true;

    }
    void AssignObject()
    {

        FemaleHairs[0] = GameObject.Find("FemaleHair1");
        FemaleHairs[1] = GameObject.Find("FemaleHair2");
        FemaleHairs[2] = GameObject.Find("FemaleHair3");
        FemaleHairs[3] = GameObject.Find("FemaleHair4");
        FemaleHairs[4] = GameObject.Find("FemaleHair5");

        MaleHairs[0] = GameObject.Find("MaleHair1");
        MaleHairs[1] = GameObject.Find("MaleHair2");
        MaleHairs[2] = GameObject.Find("MaleHair3");
        MaleHairs[3] = GameObject.Find("MaleHair4");
    }
}
