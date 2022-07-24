using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene ("StageChoice");
        
        } 
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene ("Title");
        
        } 
    }
}
