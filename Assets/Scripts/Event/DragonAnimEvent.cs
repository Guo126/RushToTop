using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonAnimEvent : MonoBehaviour {

    public FUntyEvent OnAttack;
    [SerializeField] private int hurt = 20;

    void AttackTo()
    {

        PlayerMes.getInstance().BloodNum -= hurt;
        OnAttack.Invoke((float)PlayerMes.getInstance().BloodNum / PlayerMes.getInstance().BloodMax);
        //print(PlayerMes.getInstance().BloodNum);

    }
}
