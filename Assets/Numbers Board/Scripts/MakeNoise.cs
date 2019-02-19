using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MakeNoise : MonoBehaviour {

    public AudioClip hit;
    public AudioSource emit;
    public GameObject myTimer;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
        print("hit");
        if (col.gameObject.tag == "wall")
        {
            emit.PlayOneShot(hit);
            
            myTimer.GetComponent<TimerScript>().Penalty();
        }

    }
}
