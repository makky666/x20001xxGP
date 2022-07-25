using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BigForest : MonoBehaviour
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
            SoundManager.Instance.PlaySE(SESoundData.SE.Submit);
            SceneManager.LoadScene ("Stage1");
        
        } 
         if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene ("StageChoice");
        
        } 
    }
}
