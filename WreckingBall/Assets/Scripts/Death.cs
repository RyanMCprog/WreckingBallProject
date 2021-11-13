using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public ParticleSystem DeathParticle;
    public GameObject HalfCircleOne;
    public GameObject HalfCircleTwo;
    public CameraController cameraController;

    public Vector3 HalfCircleOneOffset = new Vector3(-0.5f,0,0);
    public Vector3 HalfCircleTwoOffset = new Vector3(0.5f, 0, 0);

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Obstacle"))
        {
            Dead();
        }
    }

    public void Dead()
    {
        Instantiate(DeathParticle, transform.position, Quaternion.identity);
        Instantiate(HalfCircleOne, transform.position + HalfCircleOneOffset, Quaternion.identity);
        Instantiate(HalfCircleTwo, transform.position + HalfCircleTwoOffset, Quaternion.identity);
        cameraController.enabled = false;

        Destroy(gameObject);
    }
}
