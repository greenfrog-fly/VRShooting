using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target3 : MonoBehaviour
{
    //タイム測定的制御
    public GameObject ball;
    public GameObject ball1;
    public GameObject Aim;

    float x;
    float y;
    float z;

    public GameObject DestroyScore;
    Destroy destroy;

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

        DestroyScore = GameObject.Find("destry(Clone)");
        destroy = DestroyScore.GetComponent<Destroy>();

        
    }

    // Update is called once per frame
    void Update()
    {


    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            destroy.x = destroy.x + 1;
            Instantiate(ball1);
            Destroy(ball, 0.1f);


        }
    }
}
