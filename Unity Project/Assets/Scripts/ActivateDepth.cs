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
            Back();            
        }

        if (isD)
        {
            if (activeD)
            {
                transform.position = new Vector3(992.86f, -669.37f, -11.1826f);
                //activeD = false;
            }
            
        }
        if (isF)
        {
            if (activeF)
                transform.position = new Vector3(999.3f, -683.2f, -4.932602f);
        }
        if (isM)
        {
            if (activeM)
                transform.position = new Vector3(998.68f, -682.9f, -4.020004f);
        }
        
    }

    public void Back()
    {
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
