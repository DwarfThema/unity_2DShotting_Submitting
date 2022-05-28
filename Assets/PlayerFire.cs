using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //총구위치
    public GameObject fireOrientation;

    //총알생성자
    public GameObject fireFactory;

    //총알간의 거리
    float space = 1.5f;

    //한번에 쏘는 총의 숫자
    public int bulletCount = 5;

    //총 쏠 여부
    public bool fireBoolean = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fireBoolean)
        {
            if (Input.GetButtonDown("Fire1"))
            {

                float totalSpacing = (bulletCount - 1) * space;
                // 총 거리 1개 쏘면 0 / 2개쏘면 3m / 3개쏘면 4.5m

                // 각각의 총알중 가장 왼쪽에서 나가는 bullet 위치
                Vector3 bulletPosition = fireOrientation.transform.position - new Vector3(totalSpacing * 0.5f, 0, 0);

                for (int i = 0; i < bulletCount; i++)
                {
                    GameObject bullet = Instantiate(fireFactory);

                    //총알은 i개씩 나가니 제일 왼쪽에서 나가는 bulletPosition 에서 오른쪽으로가며 ++ 로 생성
                    bullet.transform.position = bulletPosition + new Vector3(i * space, 0, 0);
                }

            }
        }

    }

}
