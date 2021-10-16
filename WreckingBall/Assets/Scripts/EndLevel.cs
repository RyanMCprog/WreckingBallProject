using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLevel : MonoBehaviour
{
    [SerializeField]
    private GameTimer Stopwatch;
    [SerializeField]
    private GameObject EndBG;
    [SerializeField]
    private Text EndTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Stopwatch.StopTimer();
            EndBG.SetActive(true);
            EndTime.text = Stopwatch.Timer.text;
        }
    }
}
