using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalScore : MonoBehaviour
{
    public Text TimeText;
    float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        timer=0;
        timer = ScoreManager.gettime();
        TimeText.text = string.Format("YourTime:{0}",timer.ToString("f2"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
