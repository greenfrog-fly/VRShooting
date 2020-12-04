using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spone : MonoBehaviour
{
    //不使用
    public GameObject Gun;
    public GameObject Gun1;
    public GameObject cntobj;
    public bool res = true;
    public Vector3 placePosition;
    public Quaternion q;


    // Start is called before the first frame update
    void Start()
    {
        cntobj = this.gameObject;
        Vector3 placePosition = new Vector3(0, 0, 0);
        Quaternion q = new Quaternion();
        q = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bex()
    {
        if (res == true)
        {
            Gun1 = Instantiate(Gun) as GameObject;
            Gun1.transform.parent = cntobj.transform;
            Debug.Log("benben2");
        }
    }
}
