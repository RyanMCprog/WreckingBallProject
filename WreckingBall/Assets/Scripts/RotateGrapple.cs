using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGrapple : MonoBehaviour
{
    public GrapplingHook GrappleHook;

    private void Update()
    {
        if (!GrappleHook.isGrappling()) return;

        transform.LookAt(GrappleHook.GrapplePoint);
    }
}
