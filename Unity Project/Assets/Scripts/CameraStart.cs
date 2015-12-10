
using UnityEngine;
using System.Collections;

public class CameraStart : MonoBehaviour {
	
	static public int posCamera;

	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey && posCamera<1)
				posCamera = 1;
		PosizioneCamera ();
	
	}

	void PosizioneCamera(){
		switch (posCamera) {
			case(1):
				transform.position = new Vector3 (-1000f, 0f, -17f);
			break;
			case(2):
                transform.position = new Vector3(0f, 0f, -17f);
                break;
			case(3):
                transform.position = new Vector3(1000f, 0f, -17f);
                break;
			

		}
	}
}
