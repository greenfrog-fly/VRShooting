using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    //ターゲットループ
    public GameObject ball;
    public GameObject ball1;
    public GameObject Aim;

    float x;
    float y;
    float z;


    public Material colorA;
    public Material colorB;

    // Start is called before the first frame update
    void Start()
    {
        Aim = GameObject.Find("AIM(Clone)");
        ball = this.gameObject;

        x = Random.Range(-1.3f, 1.33f);
        y = Random.Range(1.4f, 4.3f);
        z = Random.Range(5f, 20f);

        ball.transform.position = new Vector3(x, y, z);

        GetComponent<Renderer>().material.color = colorA.color;

        ball.transform.parent = Aim.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
            
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            GetComponent<Renderer>().material.color = colorB.color;
            Instantiate(ball);
            Destroy(ball,0.1f);


        }
    }
}
