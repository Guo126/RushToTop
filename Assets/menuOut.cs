using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuOut : MonoBehaviour {

    private bool isOut = false;
    public Sprite go ;
    public Sprite back ;


    public void menuControl()
    {
        isOut = !isOut;
        
        if (isOut)
        {
            transform.parent.Translate(new Vector3(0, -50, 0));
            gameObject.GetComponent<Image>().overrideSprite = back;
        }
        else
        {
            transform.parent.Translate(new Vector3(0, 50, 0));
            gameObject.GetComponent<Image>().overrideSprite = go;
        }
    }
}
