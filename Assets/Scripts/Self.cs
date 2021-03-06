﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Self : MonoBehaviour {

    // Use this for initialization
    public Vector3 point;
    public  float shootSpeed = 0;
    public GameObject feel;
    private AudioSource audioSource;
    public AudioClip clip;

	void Start () {
        point.y = gameObject.transform.position.y;

        MusicManager.Instance.Play(clip, 0.2f * clip.length);
       // AudioSource.PlayClipAtPoint(clip,);
	}
	
	// Update is called once per frame
	void Update () {
        var target = point - this.transform.position;
        transform.Translate(target.normalized * Time.deltaTime * shootSpeed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            
            //Instantiate(feel, gameObject.transform);
            Destroy(gameObject);
        }
    }

    

}
