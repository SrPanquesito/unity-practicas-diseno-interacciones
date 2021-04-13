using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonScriptFarming : MonoBehaviour
{
    public GameObject augmentable;
    public ControllerSample animations;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        animations.farming = true;
        Debug.Log("Se presiono el button Farming");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        animations.farming = false;
        Debug.Log("Se levanto el button Farming");
    }

    // Start is called before the first frame update
    void Start()
    {
        augmentable = GameObject.Find("BotonFarming");
        augmentable.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        augmentable.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
