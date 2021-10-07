using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GrapplingHook : MonoBehaviour
{
    private LineRenderer lr;
    [HideInInspector]
    public Vector3 GrapplePoint;
    public LayerMask WhatisGrappleable;
    public Transform GrappleTip, player;
    public Camera mainCamera;
    private float maxDistance = 100f;
    private SpringJoint joint;

    private bool EnterGrappleMode = false;

    // Start is called before the first frame update
    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(EnterGrappleMode)
        {
            if(Input.GetMouseButtonDown(0))
            {
                startGrapple();
            }
        }
        else if(!EnterGrappleMode)
        {
            stopGrapple();
        }
    }

    private void LateUpdate()
    {
        DrawRope();
    }

    public void StartGrappleMode()
    {
        EnterGrappleMode = true;
    }

    public void EndGrappleMode()
    {
        EnterGrappleMode = false;
    }

    void startGrapple()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, maxDistance, WhatisGrappleable))
        {
            if(hit.transform.gameObject.GetComponent<MakeClickable>().isClickable)
            {
                GrapplePoint = hit.point;
                joint = player.gameObject.AddComponent<SpringJoint>();
                joint.autoConfigureConnectedAnchor = false;
                joint.connectedAnchor = GrapplePoint;

                float distanceFromPoint = Vector3.Distance(player.position, GrapplePoint);

                //the distance the grapple will try to keep from grapple point
                joint.maxDistance = distanceFromPoint * 0.6f;
                joint.minDistance = distanceFromPoint * 0.18f;

                //change theses values to fit game
                joint.spring = 5.5f;
                joint.damper = 5f;
                joint.massScale = 4.5f;

                lr.positionCount = 2;
            }
            
        }
    }

    void DrawRope()
    {
        if (!joint) return;

        lr.SetPosition(0, GrappleTip.position);
        lr.SetPosition(1, GrapplePoint);
    }

    void stopGrapple()
    {
        lr.positionCount = 0;
        Destroy(joint);
    }

    public bool isGrappling()
    {
        return joint != null;
    }
}
