using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Self : MonoBehaviour {

    // Use this for initialization
    public Vector3 point;
    public  float shootSpeed = 0;
	void Start () {
        point.y = gameObject.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, point, shootSpeed);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            Invoke( "destroyArrow",0.4f);
        }
    }

    void destroyArrow()
    {
        Destroy(gameObject);
    }

}
