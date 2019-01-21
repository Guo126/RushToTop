using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Animator anim;
    private int speedID = Animator.StringToHash("Speed");
    private int isSpeedUpID = Animator.StringToHash("IsSpeedUp");
    private int horizontalID = Animator.StringToHash("Horizontal");
    private int speedZID = Animator.StringToHash("SpeedZ");
    private int speedRotateID = Animator.StringToHash("SpeedRotate");

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        anim.SetFloat(speedZID, Input.GetAxis("Vertical") * 4.1f);
        anim.SetFloat(speedRotateID, Input.GetAxis("Horizontal") * 126);

        //anim.SetFloat(speedID, Input.GetAxis("Vertical"));
        //anim.SetFloat(horizontalID, Input.GetAxis("Horizontal"));
        //if (Input.GetKeyDown(KeyCode.LeftShift))
        //{
        //    anim.SetBool(isSpeedUpID, true);
        //}
        //if (Input.GetKeyUp(KeyCode.LeftShift))
        //{
        //    anim.SetBool(isSpeedUpID, false);
        //}
    }
}
