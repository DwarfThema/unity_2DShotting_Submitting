using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   

    private void OnTriggerEnter(Collider other)
    {
        PlayerMove playerMove = other.GetComponent<PlayerMove>();

        if (playerMove)
        {
            playerMove.speed = playerMove.speed / 3;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        PlayerMove playerMove = other.GetComponent<PlayerMove>();

        if (playerMove)
        {
            playerMove.speed = playerMove.speed * 3;
        }

    }
}
