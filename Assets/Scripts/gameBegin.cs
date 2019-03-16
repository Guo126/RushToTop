using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class gameBegin : MonoBehaviour {


    public GameObject start;
	// Use this for initialization
	void Start () {
        
          Camera.main.GetComponent<VideoPlayer>().Play();
        Invoke("wait", 5f);
    }

    // Update is called once per frame
    void wait()
    {
        start.SetActive(true);
    }
}
