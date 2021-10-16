using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float timeStart;
    public Text Timer;
    private bool isLevelOver = false;
    // Start is called before the first frame update
    void Start()
    {
        Timer.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if(!isLevelOver)
        {
            timeStart += Time.deltaTime;
            Timer.text = timeStart.ToString("F2");
        }
    }

    public void StopTimer()
    {
        isLevelOver = true;
    }
}
