using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public float attackRange;
    public GameObject arrowPrefab;
    public Transform shootPoint;
    Vector3 mousePositionOnScreen;
    Vector3 screenPosition;
    Vector3 mousePositionInWorld;
    private GameObject arrow;
    private float shootSpeed = 0.1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void shootTo()
    {
        

        screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        
        Vector3 mousePositionOnScreen = Input.mousePosition;
        //让场景中的Z=鼠标坐标的Z
        mousePositionOnScreen.z = screenPosition.z;
        //将相机中的坐标转化为世界坐标
        mousePositionInWorld = Camera.main.ScreenToWorldPoint(mousePositionOnScreen);

        arrow = Instantiate(arrow, shootPoint.position, transform.rotation) as GameObject;
        arrow.transform.position = Vector3.Lerp(arrow.transform.position, mousePositionInWorld, shootSpeed);
        
    }
}
