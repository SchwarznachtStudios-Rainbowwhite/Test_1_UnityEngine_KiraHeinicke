using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerScript : MonoBehaviour
{
    [HideInInspector] public SpeakerScript S_SpeakerScript;


    public void Start()
    {
        // Holt Verbindung zum SPeakerSCript
        GameObject.Find("SpeakerGO").GetComponent<SpeakerScript>();

    }



    public void SendMessageToSpeaker()
    {
        // Gibt die im SPeaker Script festgelegte Message in der Console aus
        Debug.Log("Message received: " + S_SpeakerScript.Message);

    }



}
