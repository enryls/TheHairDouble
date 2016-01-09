using UnityEngine;
using System.Collections;

public class SelectionHairScript : MonoBehaviour {
    Color maincolor;
    Color onMouseEntercolor;
    Color onMouseClickColor;
    public bool isLeft = false;
    public bool isRight = false;
    public GameObject[] FemaleHairs = new GameObject[5];
    public int index = 0;
    public int posCapelli = 0;

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
        FemaleHairs[index].transform.position = new Vector3(-1000.4f, -530.4478f, -9.193481f);
    }
	
	// Update is called once per frame
	void Update () {


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

        if (isRight)
        {
            if (index < FemaleHairs.Length)
                index++;
            else
            {
                index = 0;
            }
            FemaleHairs[index - 1].transform.position = new Vector3(-1047.2f, -530.4478f, -9.193481f);

            FemaleHairs[index].transform.position = new Vector3(-1000.4f, -530.4478f, -9.193481f);
        }
        if (isLeft)
        {
            if (index == 0)
                index = FemaleHairs.Length - 1;
            else
            {
                index--;
            }
            FemaleHairs[index + 1].transform.position = new Vector3(-1047.2f, -530.4478f, -9.193481f);

            FemaleHairs[index].transform.position = new Vector3(-1000.4f, -530.4478f, -9.193481f);
        }
        
    }
   
  }

        
