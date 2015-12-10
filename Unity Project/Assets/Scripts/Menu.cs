using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	public bool isMale = false;
	public bool isFemale = false;
	Color maincolor;
	Color onMouseEntercolor;
	Color onMouseClickColor;
	// Use this for initialization
	void Start () {
		maincolor = new Color (0.9607f, 0.6784f, 0.3450f, 1f);
		onMouseEntercolor = new Color (0.5764f, 0.3176f, 0.5686f, 1f);
		onMouseClickColor = new Color (0.2f, 0.1882f, 0.1921f, 1f);
        GetComponent<Renderer>().material.color = maincolor;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)){
			switch (CameraStart.posCamera) {
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
			CameraStart.posCamera = 3;
		if (isMale)
            CameraStart.posCamera = 2;

    }
}
