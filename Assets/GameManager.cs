using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private int hero_index;
    public GameObject players ,hero;
    public IUnityEvent ResetBlood,ResetMagic;
    
	// Use this for initialization
	void Start () {
        hero_index = 3;
        hero = (GameObject)Instantiate(Resources.Load("Hero/" + hero_index.ToString()));
        hero.transform.SetParent(players.transform);
        switch (hero_index)
        {
            case 0:
                PlayerMes.getInstance().Init("1",400, 400, 200, 200, 60, 20, 10, 10);
                break;
            case 1:
                
                PlayerMes.getInstance().Init("1", 400, 400, 200, 200, 60, 20, 10, 10);
                break;
            case 2:
                PlayerMes.getInstance().Init("1", 400, 400, 200, 200, 60, 20, 10, 10);
                break;
            case 3:
                PlayerMes.getInstance().Init("1", 400, 400, 200, 200, 60, 20, 10, 10);
                break;
            case 4:
                PlayerMes.getInstance().Init("1", 400, 400, 200, 200, 60, 20, 10, 10);
                break;
        }

        
	}
	


	// Update is called once per frame
	void Update () {
        HeroDead();
        //ResetBlood.Invoke(PlayerMes.getInstance().BloodNum);
        //ResetMagic.Invoke(PlayerMes.getInstance().MagicNum);
    }

    void HeroDead()
    {
        if (PlayerMes.getInstance().BloodNum <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
