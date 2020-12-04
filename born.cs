using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class born : MonoBehaviour
{
    //ターゲット制御
    public GameObject Target;
    public GameObject Target1;
    public GameObject aim;

   

    // Start is called before the first frame update
    void Start()
    {
        aim = this.gameObject;
        
        Target1 = Instantiate(Target) as GameObject;

        Target1.transform.parent = aim.transform;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
