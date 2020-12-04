using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    //タイム測定制御
    int starttime = 0;

    public GameObject ta;

    public Mesh mesh;
    public MeshRenderer meshRenderer;
    public BoxCollider colider;

    public GameObject one;
    public GameObject one1;
    public GameObject two;
    public GameObject two2;
    public GameObject three;
    public GameObject three3;
    public GameObject spone;
    public GameObject spone1;
    public GameObject counttime;
    public GameObject counttime1;

    public GameObject breakobj;
    public GameObject breakscore;

    public GameObject res;
    public GameObject restime;
    public GameObject bobj;
    public GameObject bscore;
    public GameObject timer2;

    public GameObject aim;

    public AudioSource buzzer_audio;
    public AudioClip audio_buzz;

    // Start is called before the first frame update
    void Start()
    {
        starttime = Random.Range(4, 11);
        ta = this.gameObject;
        mesh = ta.GetComponent<Mesh>();
        meshRenderer = ta.GetComponent<MeshRenderer>();
        colider = ta.GetComponent<BoxCollider>();


        res = GameObject.Find("ResultTime(Clone)");
        restime = GameObject.Find("time(Clone)");
        bobj = GameObject.Find("breaktarget(Clone)");
        bscore = GameObject.Find("destry(Clone)");
        timer2 = GameObject.Find("CountTimer(Clone)");

        aim = GameObject.Find("AIM(Clone)");
        buzzer_audio = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(aim);

            Instantiate(breakobj);
            Instantiate(breakscore);
            buzzer_audio.PlayOneShot(audio_buzz);

            Invoke("Third", 1f);
            Invoke("Second", 2f);
            Invoke("First", 3f);
            Invoke("Spone", starttime);
            
            Destroy(meshRenderer);
            Destroy(colider);

            Destroy(res);
            Destroy(restime);
            Destroy(bobj);
            Destroy(bscore);
            Destroy(timer2);
        }
    }


    void First()
    {
        one1 = Instantiate(one);
        Destroy(one1, 1f);
    }

    void Second()
    {
        two2 = Instantiate(two);
        Destroy(two2, 1f);
    }

    void Third()
    {
        three3 = Instantiate(three);
        Destroy(three3, 1f);
    }

    void Spone()
    {
        counttime1 = Instantiate(counttime);
        spone1 = Instantiate(spone);
        Destroy(ta);        
    }

    
}
