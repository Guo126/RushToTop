using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour {

    private Player player;

	// Use this for initialization
	void Start () {
        player = GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag.Equals("enemy"))
        {
            
            Animator animator = transform.GetComponent<Animator>();
            animator.SetBool("isAttacking", true);

            player.target = this.transform.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        
    }
}
