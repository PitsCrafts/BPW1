using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger : MonoBehaviour
{
    public PlayableDirector Timeline;
    public GameObject Collider;
    public bool CutscenePlayed;
    private void OnTriggerEnter(Collider Stone1)
    {
        if (CutscenePlayed == false)
        {
            if (Stone1.CompareTag("Player"))
            {
                Debug.Log("entered");
                Timeline.Play();
                CutscenePlayed = true;
            }
        }
        
    }
}
