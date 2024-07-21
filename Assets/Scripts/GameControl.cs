using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Apple.ReplayKit;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public UnityEngine.UI.Text TimeText, BalloonText;
    public GameObject Pop;
    public GameObject ReplayGame;
    public ReplayGame ReplayGame;
    public float Timer = 60;
    int Pops = 0;

    // Start is called before the first frame update
    void Start()
    {
        BalloonText.text = "Pops : " + Pops;
        ReplayGame.ActivateReplayButton();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > 0)
        { 
        Timer -= Time.deltaTime;
        TimeText.text = "Time:" + (int)Timer;
        } else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balloon");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(Pop, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
            
        }
        if (Timer <0)
        {
            ReplayGame.SetActive(true);
        }

        
    }

    public void AddBalloon()
    {
        Pops++;
        BalloonText.text = "Pops: " + Pops;
        object ReplayButton = ReplayButton.RestartGame();
    }
}
