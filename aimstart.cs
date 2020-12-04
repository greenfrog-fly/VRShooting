using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimstart : MonoBehaviour
{
    //初期的設置
    public  GameObject ton;
    public GameObject tonton;

    // Start is called before the first frame update
    void Awake()
    {
        ton = Instantiate(tonton) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
