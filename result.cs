using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class result : MonoBehaviour
{
    //リザルトタイム制御
    public GameObject sphere;
    public timer1 Timer1;
    public GameObject tetete;

    float resulttime;
    string time;

    

    // Start is called before the first frame update
    void Start()
    {
        sphere = GameObject.Find("CountTimer(Clone)");
        Timer1 = sphere.GetComponent<timer1>();
        resulttime = Timer1.time;
        time = resulttime.ToString("f2");
        tetete.GetComponent<TextMesh>().text = time;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
