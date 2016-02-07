using UnityEngine;
using System.Collections;

public class GrabRotateScript : MonoBehaviour 
{
	[Tooltip("Material used to outline the object when selected.")]
	public Material selectedObjectMaterial;

	[Tooltip("Smooth factor used for object rotations.")]
	public float smoothFactor = 3.0f;

	[Tooltip("GUI-Text used to display information messages.")]
	public GUIText infoGuiText;

	
	private InteractionManager manager;
	private bool isLeftHandDrag;

	private GameObject selectedObject;
	private Material savedObjectMaterial;
    private Color onMouseEntercolor = new Color(0.9607f, 0.6784f, 0.3450f, 1f);
    private Color maincolor = new Color(0f, 0f, 0f, 1f);
    public bool isMale = false;
    public bool isFemale = false;
    public bool isBack1 = false;
    public bool isBack2 = false;
    public bool isBack3 = false;
    public bool isContinue1 = false;
    public bool isContinue2 = false;
    public bool isScan = false;


    void Update() 
	{
		manager = InteractionManager.Instance;

		if(manager != null && manager.IsInteractionInited())
		{
            

            Vector3 screenNormalPos = Vector3.zero;
			Vector3 screenPixelPos = Vector3.zero;

			if(selectedObject == null)
			{
				// no object is currently selected or dragged.
				// if there is a hand grip, try to select the underlying object and start dragging it.
				if(manager.IsLeftHandPrimary())
				{
					// if the left hand is primary, check for left hand grip
					if(manager.GetLastLeftHandEvent() == InteractionManager.HandEventType.Grip)
					{
						isLeftHandDrag = true;
						screenNormalPos = manager.GetLeftHandScreenPos();
					}
				}
				else if(manager.IsRightHandPrimary())
				{
					// if the right hand is primary, check for right hand grip
					if(manager.GetLastRightHandEvent() == InteractionManager.HandEventType.Grip)
					{
						isLeftHandDrag = false;
						screenNormalPos = manager.GetRightHandScreenPos();
					}
				}
				
				// check if there is an underlying object to be selected
				if(screenNormalPos != Vector3.zero)
				{
					// convert the normalized screen pos to pixel pos
					screenPixelPos.x = (int)(screenNormalPos.x * Camera.main.pixelWidth);
					screenPixelPos.y = (int)(screenNormalPos.y * Camera.main.pixelHeight);
					Ray ray = Camera.main.ScreenPointToRay(screenPixelPos);

                    // check for underlying objects
                    RaycastHit hit;
					if(Physics.Raycast(ray, out hit))
					{
						if(hit.collider.gameObject == gameObject)
						{
							selectedObject = gameObject;
                            
                        }
					}
				}
				
			}
			else
			{
                

                if (isFemale)
                {
                    CameraPosition.posCamera = 2;
                    StartSceneButton.activeF = true;
                    GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(999.88f, -675.04f, -3.43f);
                }

                if (isMale)
                {
                    CameraPosition.posCamera = 2;
                    StartSceneButton.activeM = true;
                    GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(999.28f, -674.69f, -3.5f);
                }

                if (isScan)
                {

                    ScanSceneButton.scan = true;
                    ScanSceneButton.activeD = true;
                    GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(993.83f, -669.6f, -11.7f);

                }

                if (isBack1)
                {
                    print("Back");
                    CameraPosition.posCamera = 1;
                    StartSceneButton.activeM = false;
                    StartSceneButton.activeF = false;
                    ScanSceneButton.activeD = false;
                    GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(947.5f, -668.01f, -11.1826f);
                    GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(944.7f, -682.9f, -4.020004f);
                    GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(945.3f, -683.2f, -4.932602f);
                    isBack1 = false;
                }

                if (isContinue1)
                {
                    CameraPosition.posCamera = 3;

                    //Fix this movement
                    if (ScanSceneButton.activeD)
                    {
                        GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(-1005.3f, -501.4f, -14.8f);

                    }
                    if (StartSceneButton.activeF)
                    {
                        GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(-999.25f, -506.84f, -6.53f);
                        //ActivateDepth.activeF = false;
                    }
                    if (StartSceneButton.activeM)
                    {
                        GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(-999.85f, -506.49f, -6.6f);
                        //ActivateDepth.activeM = false;
                    }
                }
                if (isBack2)
                {
                    CameraPosition.posCamera = 2;
                    if (ScanSceneButton.activeD)
                        GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(993.83f, -669.6f, -11.7f);

                    if (StartSceneButton.activeF)
                    {
                        GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(999.88f, -675.04f, -3.43f);

                    }

                    if (StartSceneButton.activeM)
                    {
                        GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(999.28f, -674.69f, -3.5f);

                    }

                    //Mancano Spostamenti Capelli (Potresti mettere un boolean?)        
                    
                    SelectionHairScript.index = 0;

                }

                if (isContinue2)
                {
                    CameraPosition.posCamera = 4;

                    if (ScanSceneButton.activeD)
                        GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(-5.4f, -501.2f, -16.4f);

                    if (StartSceneButton.activeF)
                    {
                        //FemaleHairs[index].transform.position = new Vector3(0.14f, -514.83f, -9.853479f);
                        GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(0.65f, -506.64f, -8.13f);
                    }
                    if (StartSceneButton.activeM)
                    {
                       // MaleHairs[index].transform.position = new Vector3(0.14f, -514.83f, -9.853479f);
                        GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(0.05f, -506.29f, -8.2f);
                    }


                }
                if (isBack3)
                {
                    //If Click on Back
                    ScanSceneButton.changeScene = true;
                    CameraPosition.posCamera = 3;
                    if (ScanSceneButton.activeD)
                        GameObject.FindGameObjectWithTag("ScanObject").transform.position = new Vector3(-1005.3f, -501.4f, -14.8f);

                    if (StartSceneButton.activeF)
                    {
                        GameObject.FindGameObjectWithTag("woman").transform.position = new Vector3(-999.25f, -506.84f, -6.53f);
                    }

                    if (StartSceneButton.activeM)
                    {
                        GameObject.FindGameObjectWithTag("man").transform.position = new Vector3(-999.55f, -506.49f, -6.6f);
                    }

                }

            }
		}
	}


	

}
