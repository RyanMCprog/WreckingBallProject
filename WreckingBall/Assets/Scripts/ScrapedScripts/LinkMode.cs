using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkMode : MonoBehaviour
{
    //Too Glichy to work right use grappling method for swing
    private Vector3 mOffset;
    private float mZCoord;
    public GameObject ChainEnd;
    public GameObject wreckingBall;

    private bool isLinkMode = false;

    // Update is called once per frame
    void Update()
    {
        if(isLinkMode)
        {
            ChainEnd.transform.position = GetMouseWorldPos() + mOffset;
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    public void EnterLinkMode()
    {
        ChainEnd.transform.position = wreckingBall.transform.position;
        mZCoord = Camera.main.WorldToScreenPoint(ChainEnd.transform.position).z;
        mOffset = ChainEnd.transform.position - GetMouseWorldPos();
        isLinkMode = true;
    }

    public void ExitLinkMode()
    {
        isLinkMode = false;
    }
}
