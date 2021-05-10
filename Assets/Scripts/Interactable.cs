using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using IBM.Watsson.Examples;

public class Interactable : MonoBehaviour
{
    public bool insideZone = false;
    // public KeyCode interactionButton = KeyCode.E;
    public string interactionButton = "InteractJoystick";

    public string voiceCommand = "come";

    void Start() 
    {
        SpeechToText commandProcessor = GameObject.FindObjectOfType<SpeechToText>();
        commandProcessor.onVoiceCommandRecognized += OnVoiceCommandRecognized;  
    }

    public virtual void Update() {
        // if(insideZone && Input.GetKeyDown(interactionButton)) {
        if (insideZone && CrossPlatformInputManager.GetButtonDown(interactionButton)) {
            Interact();
        }
    }

    public void OnVoiceCommandRecognized(string command) {
        if (command.ToLower() == voiceCommand.ToLower() && insideZone)
        {
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
