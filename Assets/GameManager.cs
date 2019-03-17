using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private int hero_index;

    public IUnityEvent OnLevelChanged;

	// Use this for initialization
	void Start () {
        hero_index = PlayerPrefs.GetInt("hero_index");
        switch (hero_index)
        {
            case 0:
                PlayerMes.getInstance().Init(200, 200, 200, 200, 60, 20, 10, 10);
                break;
            case 1:
                PlayerMes.getInstance().Init(200, 200, 200, 200, 60, 20, 10, 10);
                break;
            case 2:
                PlayerMes.getInstance().Init(200, 200, 200, 200, 60, 20, 10, 10);
                break;
            case 3:
                PlayerMes.getInstance().Init(200, 200, 200, 200, 60, 20, 10, 10);
                break;
            case 4:
                PlayerMes.getInstance().Init(200, 200, 200, 200, 60, 20, 10, 10);
                break;
        }

        OnLevelChanged.Invoke(PlayerMes.getInstance().BloodNum);
        OnLevelChanged.Invoke(PlayerMes.getInstance().MagicNum);
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
