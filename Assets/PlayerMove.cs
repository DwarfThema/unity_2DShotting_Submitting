using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10;

    public int score = 0;

    public Background bg;

    int checkPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = Vector3.right * Input.GetAxis("Horizontal") + Vector3.up * Input.GetAxis("Vertical");

        transform.position += dir * speed * Time.deltaTime;

    }

    public void AddScore(int point)
    {
        score += point;

        if (score % 2 == 0 && score > checkPoint)
        {
            bg.AddAccelerate(20.0f);
            checkPoint = score;
        }
    }

}