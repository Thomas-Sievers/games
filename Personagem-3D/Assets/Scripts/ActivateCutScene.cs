using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ActivateCutScene : MonoBehaviour
{
    [SerializeField] private PlayableDirector PlayableDirector;
    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
        {
            Debug.Log("Cutscene Activated");
            PlayableDirector.Play();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
