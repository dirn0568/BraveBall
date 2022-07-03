using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barmove : MonoBehaviour
{
    GameObject ball;
    Vector2 ballPos;
    // Start is called before the first frame update
    void Start()
    {
        this.ball = GameObject.Find("ball");
    }

    // Update is called once per frame
    void Update()
    {
        this.ballPos = this.ball.transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(this.ballPos);
        }
    }
}
