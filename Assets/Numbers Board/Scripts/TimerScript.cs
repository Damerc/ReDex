using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    public float myTime;
    public int startTime = 0;
    public int ding = 300;
    public Text disTimer;
    
    
    // Use this for initialization
    void Start () {
        myTime = startTime;
        	
	}

    // Update is called once per frame
    void Update()
    {
        myTime = myTime += Time.deltaTime;

        string minutes = Mathf.Floor(myTime / 60).ToString("00");
        string seconds = (myTime % 60).ToString("00");
        //print(string.Format("{0}:{1}", minutes, seconds));
        disTimer.text = string.Format("{0}:{1}", minutes, seconds);

        if (Input.GetKeyDown("p"))
        {
            Penalty();
        }
    }
        public void Penalty()
    {
        myTime = myTime + ding;
    }

    

}
