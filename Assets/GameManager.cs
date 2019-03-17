using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private int hero_index;
    public GameObject players;
    public IUnityEvent ResetBlood,ResetMagic;

	// Use this for initialization
	void Start () {
        hero_index = PlayerPrefs.GetInt("hero_index");
        players.transform.GetChild(hero_index).gameObject.SetActive(true);
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

        ResetBlood.Invoke(PlayerMes.getInstance().BloodNum);
        ResetMagic.Invoke(PlayerMes.getInstance().MagicNum);
	}
	


	// Update is called once per frame
	void Update () {
        HeroDead();
	}

    void HeroDead()
    {
        if (PlayerMes.getInstance().BloodNum <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
