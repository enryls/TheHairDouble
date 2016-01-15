using UnityEngine;
using System.Collections;

public class HandControll : MonoBehaviour {

    private GameObject RightHand; // I create variable
    private GameObject LeftHand;
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // If Right Hand is empty null it finding else it changing hand position
        if (RightHand == null)
        {
            RightHand = GameObject.Find("HandRight");
        }
        else
        {
            gameObject.transform.position = new Vector3(RightHand.transform.position.x,
            RightHand.transform.position.y,
            transform.position.z
            );

        }
        /*if(LeftHand == null)
        {
            LeftHand = GameObject.Find("HandLeft");
        }
        else
        {
            LeftHand.transform.position = new Vector3(LeftHand.transform.position.x,
            LeftHand.transform.position.y,
            transform.position.z
            );

        }*/
        

    }
}
