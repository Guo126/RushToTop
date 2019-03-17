using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class Player : MonoBehaviour {

    private Animator anim;
    
    private int speedID = Animator.StringToHash("Speed");
    private int isSpeedUpID = Animator.StringToHash("IsSpeedUp");
    private int horizontalID = Animator.StringToHash("Horizontal");
    private int speedZID = Animator.StringToHash("SpeedZ");
    private int speedRotateID = Animator.StringToHash("SpeedRotate");

    private Vector3 direction = Vector3.zero;
    public Vector3 target;

    public float speed = 3f;
    public GameObject perfab;
    private CharacterController characterController;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
	    characterController = GetComponent<CharacterController>();

	    target = transform.position;
	}
	
	// Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(1))
        {
            LayerMask lm = 1 << LayerMask.NameToLayer("Road");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction, Color.blue);
            RaycastHit info;
            Physics.Raycast(ray, out info, 1000f, lm.value);
           
            if (perfab != null)
                GameObject.Instantiate(perfab, info.point, Quaternion.identity);

            target = info.point;


        }

        direction = target - transform.position;
        direction.y = 0;
        //direction = direction.normalized;

        if (direction.magnitude < 0.3f)
        {
            direction = Vector3.zero;
            target = transform.position;

        }

        target.y = this.transform.position.y;
        this.transform.LookAt(target);
        characterController.SimpleMove(direction.normalized * speed);
        anim.SetFloat(speedID, Mathf.Clamp01(Mathf.Abs(direction.sqrMagnitude)));
        //anim.SetFloat(speedRotateID, direction.z * 126);

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
