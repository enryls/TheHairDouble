using UnityEngine;
using System.Collections;

public class StartSceneButton : MonoBehaviour {
	public bool isMale = false;
	public bool isFemale = false;
    public bool isTryOnYourSelf = false;
    public bool isGoToScan = false;
    public bool isExit = false;
    static public bool activeM;
    static public bool activeF;
    Color maincolor;
	Color onMouseEntercolor;
	Color onMouseClickColor;


    // Use this for initialization
    void Start () {
		maincolor = new Color (0f, 0f, 0f, 1f);
		onMouseEntercolor = new Color (0.9607f, 0.6784f, 0.3450f, 1f);
		onMouseClickColor = new Color (0.2f, 0.1882f, 0.1921f, 1f);
        GetComponent<Renderer>().material.color = maincolor;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)){
			switch (CameraPosition.posCamera) {
			case(1):
				Application.Quit();
				break;
			}

            if (InteractionManager.mouseclick)
                OnMouseUp();
		
		}
	
	}

    void OnMouseEnter()
    {
        //Color of the Buttons on Mouse Enter
       if (!isMale && !isFemale)
            GetComponent<Renderer>().material.color = onMouseEntercolor;
    }

    void OnMouseExit()
    {
        //Color of the buttons on Mouse Exit return to main color if isn't male or female
        if (!isMale && !isFemale)
            GetComponent<Renderer>().material.color = maincolor;
    }
    void OnMouseUp()
    {
        //Color of the buttons on Mouse Up
        GetComponent<Renderer>().material.color = onMouseClickColor;

        //Change the position of the Camera and select the correct body model for the gender selected
        if (isFemale)
        {
            GetComponent<Renderer>().material.color = onMouseEntercolor;
            GameObject.FindGameObjectWithTag("M").GetComponent<Renderer>().material.color = maincolor; 
            activeF = true;
            activeM = false;
                     
        }

        if (isMale)
        {
            GetComponent<Renderer>().material.color = onMouseEntercolor;
            GameObject.FindGameObjectWithTag("F").GetComponent<Renderer>().material.color = maincolor;

            activeM = true;
            activeF = false;
            
        }
        if (activeF || activeM)
        {
            if (isGoToScan)
            {
                CameraPosition.posCamera = 2;
                if (activeM)
                {
                    GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(999.22f, -678.53f, -9.98f);
                    //GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(999.28f, -674.69f, -3.5f);
                }
                else if (activeF)
                {
                    GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(998.95f, -678.34f, -12.01f);

                    //GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(999.88f, -675.04f, -3.43f);
                }
            }

            if (isTryOnYourSelf)
            {
                CameraPosition.posCamera = 5;
                SelectHairForYryScene.CCCCChanges = true;
                //Application.LoadLevel("SceneTryToYourself");
            }
            
        }
        if (isExit)
        {
            Application.Quit();
        }
    }
    
}
