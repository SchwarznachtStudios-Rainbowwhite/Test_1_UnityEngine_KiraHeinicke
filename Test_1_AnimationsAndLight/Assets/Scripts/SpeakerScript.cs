using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerScript : MonoBehaviour
{
    [HideInInspector] public ListenerScript S_ListenerScript;

    [HideInInspector] public string Message;


    public void Start()
    {
        // Holt ListenerScript Verbindung
        GameObject.Find("ListenerGO").GetComponent<ListenerScript>();

        // Führt Funktion aus
        SetMessage();

    }


    public void SetMessage()
    {
        // Setzt die Message
        Message = "Secret";

    }



    public void UseListenerMethod()
    {

        // Ruft Funktion aus dem ListenerScript auf
        S_ListenerScript.SendMessageToSpeaker();



    }



}
