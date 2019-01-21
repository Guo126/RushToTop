using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

    private Transform playerTransform;
    private Vector3 targetPosition;
    private Vector3 offset;
    private int smooth = 3;
    
	void Start () {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        offset = gameObject.transform.position - playerTransform.position;
	}

    void LateUpdate() {
        targetPosition = playerTransform.position + playerTransform.TransformDirection(offset);//
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, targetPosition, Time.deltaTime * smooth);
        gameObject.transform.LookAt(playerTransform);
    }
}
