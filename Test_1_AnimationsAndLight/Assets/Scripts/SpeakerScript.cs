using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerScript : MonoBehaviour
{
    public ListenerScript S_ListenerScript;






    public void UseListenerMethod()
    {
        S_ListenerScript.SendMessageToSpeaker();

    }



}
