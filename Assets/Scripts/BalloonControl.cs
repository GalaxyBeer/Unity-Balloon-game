using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonControl : MonoBehaviour
{
    public GameObject Pop;
    GameControl gameControl;

    private void Start()
    {
        gameControl = GameObject.Find("Scripts").GetComponent<GameControl>();

    }
    private void OnMouseDown()
    {
        GameObject go =Instantiate(Pop, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.350f);
        gameControl.AddBalloon();
    }
}
