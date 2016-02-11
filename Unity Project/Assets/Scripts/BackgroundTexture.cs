using UnityEngine;
using System.Collections;

public class BackgroundTexture : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        switch (BackgroundSceneComponent.index)
        {
            case (0):
                GetComponent<GUITexture>().texture = Resources.Load("364heMa") as Texture2D;
                break;
            case (1):
                GetComponent<GUITexture>().texture = Resources.Load("469946") as Texture2D;
                break;
            case (2):
                GetComponent<GUITexture>().texture = Resources.Load("background4") as Texture2D;
                break;
            case (3):
                GetComponent<GUITexture>().texture = Resources.Load("Download-New-York-City-Desktop-Wallpaper") as Texture2D;
                break;
            case (4):
                GetComponent<GUITexture>().texture = Resources.Load("london-city-photos-wallpaper-widescreen-rf12807i") as Texture2D;
                break;
            case (5):
                GetComponent<GUITexture>().texture = Resources.Load("beautiful-house-high-definition-wallpapers-cool-desktop-images-widescreen") as Texture2D;
                break;
            case (6):
                GetComponent<GUITexture>().texture = Resources.Load("Mountain-Wallpaper-Iphone-HD") as Texture2D;
                break;
            case (7):
                GetComponent<GUITexture>().texture = Resources.Load("streetsoftokyo-744809") as Texture2D;
                break;

        }
        
    }
}
