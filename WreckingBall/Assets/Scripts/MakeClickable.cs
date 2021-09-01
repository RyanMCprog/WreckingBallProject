using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeClickable : MonoBehaviour
{
    private bool isClickable;

    public Material Clickable;
    public Material notClickable;
    public float clickRange = 10f;

    Renderer rend;

    public GameObject wreckingBall;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(gameObject.transform.position, wreckingBall.transform.position) <= clickRange)
        {
            rend.material = Clickable;
            isClickable = true;
        }
        else
        {
            rend.material = notClickable;
            isClickable = false;
        }
    }

    private void OnMouseDown()
    {
        if(isClickable)
        {
            Debug.Log("Clicked");
        }
    }
}
