using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    //弾数表示制御
    public GameObject MagShell;
    public Gun gun;
    public GameObject Root;
    int shell;
    string tama;

    Color newColor1 = Color.white;
    Color newColor2 = Color.red;



    // Start is called before the first frame update
    void Start()
    {
        MagShell = GameObject.Find("Handgun_M1911A(Clone)");
        gun = MagShell.GetComponent<Gun>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shell > 0)
        {
            shell = gun.silver;
            tama = shell.ToString();
            Root.GetComponent<TextMesh>().color = newColor1;
            Root.GetComponent<TextMesh>().text = tama;
        }
        else
        {
            shell = gun.silver;
            tama = shell.ToString();
            Root.GetComponent<TextMesh>().color = newColor2;
            Root.GetComponent<TextMesh>().text = tama;
        }
    }
}
