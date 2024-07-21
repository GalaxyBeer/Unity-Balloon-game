using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonCreate : MonoBehaviour
{
    public GameObject red;
    float balloonCreateTime = 0.5f;
    public float Timer = 0f;
    GameControl gameControl;
    // Start is called before the first frame update
    void Start()
    {
        gameControl = this.gameObject.GetComponent<GameControl>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        int Unit = (int)(gameControl.Timer / 20) - 6;
        Unit *= -1;

        if (Timer<0 && gameControl.Timer >0)
        {
            GameObject go =Instantiate(red, new Vector3(Random.Range(-1.85f,1.85f), -5.6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(30*Unit,80*Unit), 0));
            Timer = balloonCreateTime;
        }
        
    }
}
