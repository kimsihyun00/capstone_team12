using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    MeshRenderer meshRender;
    MeshCollider meshCollider;
    AudioSource audioSource;

    private void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
        meshCollider = GetComponent<MeshCollider>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag.Equals("Stone"))
        {
            audioSource.Play();
            meshRender.enabled = false;
            meshCollider.enabled = false;
        }
    }
}
