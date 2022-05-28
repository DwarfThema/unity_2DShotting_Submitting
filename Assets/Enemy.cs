using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 dir = Vector3.down;

    public float speed = 5;

    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        int result = UnityEngine.Random.Range(0, 10);

        target = GameObject.Find("Player");

        if(result > 3)
        {
            
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);

        Destroy(gameObject);

        if (other.gameObject.name.Contains("Bullet"))
        {
            PlayerMove player = target.GetComponent<PlayerMove>();

            player.AddScore(1);
        }

    }
}
