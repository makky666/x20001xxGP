using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SceneManager.LoadScene ("BigForest");
        
        } 
        if (Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene ("BlueCastle");
        
        } 
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene ("Title");
        
        } 
    }
}
