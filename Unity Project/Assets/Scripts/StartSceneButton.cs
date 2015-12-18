using UnityEngine;
using System.Collections;

public class StartSceneButton : MonoBehaviour {
	public bool isMale = false;
	public bool isFemale = false;
    static public bool maleMode;
    static public bool femaleMode;
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

		
		}
		/*if (Input.GetKey (KeyCode.Return)) {
			Application.LoadLevel ("FirstLv");
		}*/
	}

	void OnMouseEnter(){
        GetComponent<Renderer>().material.color = onMouseEntercolor;
	}

	void OnMouseExit(){
        GetComponent<Renderer>().material.color = maincolor;
	}
	void OnMouseUp(){
        GetComponent<Renderer>().material.color = onMouseClickColor;
		if (isFemale)
        {
            CameraPosition.posCamera = 3;
            maleMode = false;
            femaleMode = true;
            
        }
			
		if (isMale)
            CameraPosition.posCamera = 2;
            femaleMode = false;
            maleMode = true;
            

    }
}
