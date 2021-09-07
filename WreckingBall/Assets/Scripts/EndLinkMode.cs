using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EndLinkMode : MonoBehaviour, IPointerEnterHandler
{
    public Canvas LinkModeUI;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        LinkModeUI.gameObject.SetActive(false);
    }
}
