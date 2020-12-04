using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sil : MonoBehaviour
{
    //リロード後の弾数
    public GameObject MagShell;
    public Gun gun;

    // Start is called before the first frame update
    void Start()
    {
        MagShell = GameObject.Find("Handgun_M1911A(Clone)");
        gun = MagShell.GetComponent<Gun>();
        gun.silver = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
