using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restricted : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public AudioSource redzone;
    private void Start()
    {
        // Get the MeshRenderer component attached to the current object
        meshRenderer = GetComponent<MeshRenderer>();

    }
  
        private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            meshRenderer.enabled = true;
            redzone.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            meshRenderer.enabled = false;
            redzone.Stop();
        }
    }
}
