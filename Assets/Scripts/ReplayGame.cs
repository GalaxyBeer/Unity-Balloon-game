using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ReplayGame : MonoBehaviour
{
    public GameObject ReplayButton;
    public string sceneToLoad = "SampleScene";
    // Start is called before the first frame update
    void Start()
    {
        ReplayButton.SetActive(false);
        
    }

    public void ActivateReplayButton()
    {
        ReplayButton.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
