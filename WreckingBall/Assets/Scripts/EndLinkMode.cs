using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EndLinkMode : MonoBehaviour, IPointerEnterHandler
{
    public Canvas LinkModeUI;
    public GrapplingHook CanHook; 
    //add when stop grapple is there
    
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        LinkModeUI.gameObject.SetActive(false);
        //add when stopgrapple is implemented
        CanHook.EndGrappleMode();
       
    }
}
