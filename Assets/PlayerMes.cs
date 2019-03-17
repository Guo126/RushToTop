using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMes : MonoBehaviour {


    private int bloodNum;
    private int bloodMax;
    private int magicNum;
    private int magicMax;
    private int attack;

    private int defence;

    private int hidePer;

    private int bigHit;


     public void Init(int bloodNum,int bMax, int magicNum, int mMax,int attack, int defence, int hidePer, int bigHit)
    {
        this.bloodNum = bloodNum;
        this.bloodMax = bMax;
        this.magicNum = magicNum;
        this.magicMax = mMax;
        this.attack = attack;
        this.defence = defence;
        this.hidePer = hidePer;
        this.bigHit = bigHit;
    }

    static private PlayerMes instance = new PlayerMes() ;

    public int BloodNum
    {
        get
        {
            return bloodNum;
        }

        set
        {
            bloodNum = value;
        }
    }

    public int MagicNum
    {
        get
        {
            return magicNum;
        }

        set
        {
            magicNum = value;
        }
    }

    public int Attack
    {
        get
        {
            return attack;
        }

        set
        {
            attack = value;
        }
    }

    public int Defence
    {
        get
        {
            return defence;
        }

        set
        {
            defence = value;
        }
    }

    public int HidePer
    {
        get
        {
            return hidePer;
        }

        set
        {
            hidePer = value;
        }
    }

    public int BigHit
    {
        get
        {
            return bigHit;
        }

        set
        {
            bigHit = value;
        }
    }

    public int BloodMax
    {
        get
        {
            return bloodMax;
        }

        set
        {
            bloodMax = value;
        }
    }

    public int MagicMax
    {
        get
        {
            return magicMax;
        }

        set
        {
            magicMax = value;
        }
    }

    static public PlayerMes getInstance()
    {
        return instance;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void init(int blood,int magic,int attack,int defence,int hidePer,int bigHit)
    {
        
    }
    
}
