using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeMenu : MonoBehaviour {

    public Sprite[] menus  ;
    private int index = 0;
    public GameObject menu;
    public GameObject start, world, overlay, hero;


	// Use this for initialization
	void Start () {
        //if 第一次进入游戏
        menu.GetComponent<Image>().overrideSprite = menus[0];
        index = 0;
        //else{
        //menu.GetComponent<Image>().overrideSprite = menus[1];
        //index = 1;
        //}


    }
    public void theMenu()
    {
        if (index == 0)
        {
            start.SetActive(false);
            world.SetActive(true);
            overlay.SetActive(true);
            hero.SetActive(true);
        }
    }
	
	public void nextMenu()
    {
        if(index == 3)
        {
            index = 0;
        }
        else{
            index += 1;
        }
       
        menu.GetComponent<Image>().overrideSprite = menus[index];
    }

    public void beforeMenu()
    {
        if (index == 0)
        {
            index = 3;
        }
        else
        {
            index -= 1;
        }

        menu.GetComponent<Image>().overrideSprite = menus[index];
    }

}
