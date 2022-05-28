using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject enemyPrefab;

    float passingTime;

    public float creationTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        passingTime += Time.deltaTime;

        if(passingTime > creationTime)
        {
            GameObject enemy = Instantiate(enemyPrefab);

            enemy.transform.position = transform.position;

            passingTime = 0;
        }
    }
}
