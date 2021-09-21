using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3 GrapplePoint;
    public LayerMask WhatisGrappleable;

    private bool EnterGrappleMode = false;

    // Start is called before the first frame update
    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGrappleMode()
    {
        EnterGrappleMode = true;
    }

    public void EndGrappleMode()
    {
        EnterGrappleMode = false;
    }
}
