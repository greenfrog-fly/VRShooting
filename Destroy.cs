using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //ターゲット破壊数
    public GameObject score;

    public float x;
    float resulttime;
    string time;



    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        
        

    }

    // Update is called once per frame
    void Update()
    {
        resulttime =  x;
        time = resulttime.ToString();
        score.GetComponent<TextMesh>().text = time;
    }
}
