using UnityEngine;
using System.Collections;

public class ActivateDepth : MonoBehaviour {

     static public bool activeD;

    // Use this for initialization
    void Start () {
        
        activeD = false;

    }

    // Update is called once per frame
    void Update () {
        if(activeD)
            transform.position = new Vector3(992.86f, -668.01f, -11.1826f);
    }
}
