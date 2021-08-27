using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float Speed = 10f;
    public float autoSpeed = 5f;

    private float xInput, zInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        Debug.Log(zInput);
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(xInput, 0, 0) * Speed);
        
        if(zInput > -0.1 && zInput < 0.1)
        {
            rb.AddForce(Vector3.forward * autoSpeed);
        }
        else if(Mathf.Sign(zInput) == -1)
        {
            rb.AddForce(Vector3.forward);
        }
        else
        {
            rb.AddForce(Vector3.forward * (autoSpeed*2));
        }
    }
}
