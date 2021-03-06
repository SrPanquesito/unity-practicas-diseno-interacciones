using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour
{
    public Interactable interactableObject;
    public GameObject augmentable;
    public ControllerSample animations;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //interactableObject.Interact();
        animations.gathering = true;
        Debug.Log("Se presiono el button Gathering");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        animations.gathering = false;
        Debug.Log("Se levanto el button Gathering");
    }

    // Start is called before the first frame update
    void Start()
    {
        augmentable = GameObject.Find("BotonGathering");
        augmentable.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        augmentable.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
