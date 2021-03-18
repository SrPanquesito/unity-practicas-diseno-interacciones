using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Interactable : MonoBehaviour
{
    public bool insideZone = false;
    // public KeyCode interactionButton = KeyCode.E;
    public string interactionButton = "Interact";

    public virtual void Update() {
        // if(insideZone && Input.GetKeyDown(interactionButton)) {
        if(insideZone && CrossPlatformInputManager.GetButtonDown(interactionButton)) {
            Interact();
        }
    }

    void OnTriggerEnter(Collider other) {
        if(!other.CompareTag("Player")) {
            return;
        }
        Debug.Log("Entró en el area!");
        insideZone = true;
    }
    void OnTriggerExit(Collider other) {
        if(!other.CompareTag("Player")) {
            return;
        }
        Debug.Log("Salió del area!");
        insideZone = false;
    }

    public virtual void Interact() {

    }
}
