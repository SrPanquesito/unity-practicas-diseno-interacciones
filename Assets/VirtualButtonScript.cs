using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour
{
    public Interactable interactableObject;
    public GameObject augmentable;
    // private VirtualButtonBehaviour virtualButton;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        interactableObject.Interact();
        Debug.Log("Se presiono el button");
        //throw new System.NotImplementedException();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Se levanto el button");
        //throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        augmentable = GameObject.Find("Boton1");
        augmentable.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        augmentable.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
