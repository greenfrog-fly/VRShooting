using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer1 : MonoBehaviour
{
    //タイマーカウント
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }
}
