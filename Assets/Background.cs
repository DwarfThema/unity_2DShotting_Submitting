using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public float finalSpeed = 0;

    public float speed = 0.1f;
    Material mat;


    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        mat = renderer.material;

        finalSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset += Vector2.up * finalSpeed * Time.deltaTime ;
    }

    public void AddAccelerate(float addSpeed)
    {
        addSpeed = addSpeed * 0.01f;
        speed += speed * addSpeed;
    }
}
