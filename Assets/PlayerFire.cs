using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //�ѱ���ġ
    public GameObject fireOrientation;

    //�Ѿ˻�����
    public GameObject fireFactory;

    //�Ѿ˰��� �Ÿ�
    float space = 1.5f;

    //�ѹ��� ��� ���� ����
    public int bulletCount = 5;

    //�� �� ����
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
                // �� �Ÿ� 1�� ��� 0 / 2����� 3m / 3����� 4.5m

                // ������ �Ѿ��� ���� ���ʿ��� ������ bullet ��ġ
                Vector3 bulletPosition = fireOrientation.transform.position - new Vector3(totalSpacing * 0.5f, 0, 0);

                for (int i = 0; i < bulletCount; i++)
                {
                    GameObject bullet = Instantiate(fireFactory);

                    //�Ѿ��� i���� ������ ���� ���ʿ��� ������ bulletPosition ���� ���������ΰ��� ++ �� ����
                    bullet.transform.position = bulletPosition + new Vector3(i * space, 0, 0);
                }

            }
        }

    }

}
