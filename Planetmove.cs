using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planetmove : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.speed = 0.15f;
            this.startPos = Input.mousePosition;
            Debug.Log(this.startPos);
            if (this.startPos[0] >= 150)
            {
                this.speed *= 1;
            }
            else
            {
                this.speed *= -1;
            }
        }
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}