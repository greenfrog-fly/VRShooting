using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target2 : MonoBehaviour
{
    //不使用
    public GameObject aim1;

    public float time;
    public float set;

    public GameObject hitbox;
    public GameObject result;
    public GameObject resulttime;
    public GameObject st;

    public Material colorA;

    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        hitbox = this.gameObject;
        GetComponent<Renderer>().material.color = colorA.color;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    public void OnCollisionEnter(Collision collision)
    {
        set = time;
        Instantiate(aim1);
        Instantiate(result);
        Instantiate(resulttime);
        Instantiate(st);
        Destroy(hitbox);
    }
}
