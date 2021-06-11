using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRUI : MonoBehaviour
{
    public GameObject curvedPointer;
    public GameObject laserPointer;
    public LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = laserPointer.GetComponent<LineRenderer>();
    }

    public void AButtonPressed()
    {
        lineRenderer.enabled = true;
        curvedPointer.SetActive(false);
    }

}
