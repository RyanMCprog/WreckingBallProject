using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnSpawn : MonoBehaviour
{
    public float RotateSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.eulerAngles.x < 90)
        {
            transform.Rotate(new Vector3(Time.deltaTime * RotateSpeed, 0, 0));
        }
        
    }
}
