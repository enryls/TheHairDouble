using UnityEngine;
using System.Collections;

public class TryOnYourSelfCO : MonoBehaviour {

    public bool isBack = false;
    public bool isContinue = false;
    public bool isRight = false;
    public bool isLeft = false;
    Color maincolor;
    Color onMouseEntercolor;
    Color onMouseClickColor;

    public GameObject[] FemaleHairs = new GameObject[5];
    public GameObject[] MaleHairs = new GameObject[4];
    static public int index = 0;


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

        //Desable the Arrays Objects
        /*for(int i=0; i < 5; i++)
        {
            FemaleHairs[i].gameObject.SetActive(false);
            if (i < 4)
            {
                MaleHairs[i].gameObject.SetActive(false);
            }
        }*/
        FemaleHairs[0].gameObject.SetActive(false);
        FemaleHairs[1].gameObject.SetActive(false);
        FemaleHairs[2].gameObject.SetActive(false);
        FemaleHairs[3].gameObject.SetActive(false);
        FemaleHairs[4].gameObject.SetActive(false);

        MaleHairs[0].gameObject.SetActive(false);
        MaleHairs[1].gameObject.SetActive(false);
        MaleHairs[2].gameObject.SetActive(false);
        MaleHairs[3].gameObject.SetActive(false);

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
            StartSceneButton.activeM = false;
            StartSceneButton.activeF = false;
            Application.LoadLevel("MainScene");
        }

        if (isRight)
        {
            if (StartSceneButton.activeF)
            {
                print("femminadestraok");
                if (index < FemaleHairs.Length - 1)
                {
                    index++;
                    FemaleHairs[index - 1].gameObject.SetActive(false);
                    ActiveFemale();



                }

                else
                {
                    index = 0;

                    FemaleHairs[FemaleHairs.Length - 1].gameObject.SetActive(false);
                    ActiveFemale();



                }
               
            }
            if (StartSceneButton.activeM)
            {
                print("maschiodestraok");
                //Usare MaleHairs.Lenght al posto di 3 (Al momento non funziona)
                if (index < 3)
                {
                    index++;

                    MaleHairs[index - 1].gameObject.SetActive(false);
                    ActiveMale();



                }

                else
                {
                    index = 0;

                    MaleHairs[3].gameObject.SetActive(false);
                    ActiveMale();
                    //Usare MaleHairs.Lenght al posto di 3 (Al momento non funziona)


                }
            }
        }
        if (isLeft)
        {
            if (StartSceneButton.activeF)
            {
                if (index == 0)
                {
                    index = FemaleHairs.Length - 1;

                    FemaleHairs[0].gameObject.SetActive(false);
                    ActiveFemale();
                }

                else
                {
                    index--;

                    FemaleHairs[index + 1].gameObject.SetActive(false);
                    ActiveFemale();
                }
            }
            if (StartSceneButton.activeM)
            {
                if (index == 0)
                {
                    print("0MaschioLeft");
                    index = 3;

                    MaleHairs[0].gameObject.SetActive(false);
                    ActiveMale();

                    //Usare MaleHairs.Lenght al posto di 3 (Al momento non funziona)

                }

                else
                {
                    print("+MaschioLeft");
                    index--;

                    MaleHairs[index + 1].gameObject.SetActive(false);
                    ActiveMale();
                }
            }
        }
        if (isContinue)
        {
            Application.LoadLevel("SceneBackGround");
        }
    }

    void ActiveFemale()
    {
                FemaleHairs[index].gameObject.SetActive(true);
    }

    void ActiveMale()
    {
                MaleHairs[index].gameObject.SetActive(true);

    }
    void AssignObject()
    {

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
}
