using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleManager : MonoBehaviour
{
        
    // Start is called before the first frame update
    void Start()
    {
           SoundManager.Instance.PlayBGM(BGMSoundData.BGM.Title);

    }

    // Update is called once per frame
    void Update()
    {
        
         if (Input.GetKey(KeyCode.Return))
        {
            SoundManager.Instance.PlaySE(SESoundData.SE.Submit);
            SceneManager.LoadScene ("StageChoice");
        
        } 
    }
}
