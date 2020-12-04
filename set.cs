using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set : MonoBehaviour
{
    //不使用
    public GameObject targetbox;
    public GameObject targetbox1;


    float x;
    float y;
    float z;


    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(-1.3f, 1.33f);
        y = Random.Range(1.4f, 4.3f);
        z = Random.Range(5f, 20f);

        

        targetbox1 = Instantiate(targetbox);
        targetbox1.transform.position = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
