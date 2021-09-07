using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkMode : MonoBehaviour
{
    private Vector3 mousePos;
    public GameObject ChainEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //doesn't work the way I want do a different method that doesn't move the chain until you click or look in watch later for drag video
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if(Physics.Raycast(ray, out RaycastHit raycastHit))
        //{
            //ChainEnd.transform.position = new Vector3(raycastHit.point.x, raycastHit.point.y, ChainEnd.transform.position.z);
        //}
    }

    public void EnterLinkMode()
    {

    }
}
