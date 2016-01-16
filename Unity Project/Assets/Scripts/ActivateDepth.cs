using UnityEngine;
using System.Collections;

public class ActivateDepth : MonoBehaviour {

     static public bool activeD;
     static public bool activeM;
     static public bool activeF;
     public bool isD = false;
     public bool isM = false;
     public bool isF = false;

    // Use this for initialization
    void Start () {
        
       

    }

    // Update is called once per frame
    void Update()
    {
        if (ScanSceneButton.back)
        {
            //When the user click to Back
            Back();            
        }

        if (isD)
        {
            
            if (activeD)
            {
                //Set the position of Scan Object when the user click on StartCamera
                transform.position = new Vector3(993.83f, -669.6f, -11.7f);
                //activeD = false;
            }
            
        }
       
        if (isF)
        {
            //Set the position of the female body
            if (activeF)
                transform.position = new Vector3(999.88f, -675.04f, -3.43f);
        }
        if (isM)
        {
            //Set the position of the male body
            if (activeM)
                transform.position = new Vector3(999.28f, -674.69f, -3.5f);
        }
        
    }

    public void Back()
    {
        //When Back is called return the objects of the Scan Scene to start position
        if (isD)
        {

            transform.position = new Vector3(947.5f, -668.01f, -11.1826f);

        }
        if (isF)
        {

            transform.position = new Vector3(945.3f, -683.2f, -4.932602f);

        }
        if (isM)
        {

            transform.position = new Vector3(944.7f, -682.9f, -4.020004f);

        }
    }
}
