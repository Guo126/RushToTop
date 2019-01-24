using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemUseAndDestory : MonoBehaviour {

	[SerializeField]private GameObject m_ItemDescribe;
	[SerializeField]private Button useButton;
	[SerializeField]private Button deleteButton;
    public GameObject smallMenu;
    private bool isShowTip = false;
    private bool WindowShow = true;

    // Use this for initialization
    void Start () {
		//useButton.onClick.AddListener(
  //          delegate () {
  //              // 这里添加你想要监听的事件
  //              Use();
  //          }
  //      );
		//deleteButton.onClick.AddListener(
  //          delegate () {
  //              // 这里添加你想要监听的事件
  //              Destory();
  //          }
  //      );
	}

    public void OnMouseEnter()
    {
        isShowTip = true;
        //Debug.Log (cube.name);//可以得到物体的名字

    }
    public void OnMouseExit()
    {
        isShowTip = false;
    }
    public void OnGUI()
    {
        if (isShowTip)
        {         
            GUI.Window(0, new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 150, 170), Window1, "物品信息");       
        }

        if (Input.GetMouseButtonDown(1))
        {
            isShowTip = false;
            Instantiate(smallMenu);
            
        }
             
    }

    public void Window1(int WindowID)
    {

        GUIStyle style1 = new GUIStyle();
        style1.fontSize = 15;
        style1.normal.textColor = Color.yellow;
        GUIStyle style2 = new GUIStyle();
        style2.fontSize = 10;
        style2.normal.textColor = Color.white;
        GUILayout.Label( "回蓝药剂", style1);
        GUILayout.Label("  ", style1);
        GUILayout.Label("拥有 ", style1);
        GUILayout.Label("回复10%法力值", style2);
        //物品信息排版

        
    }

   
    
	public void OnValueChange()
	{
		if(gameObject.GetComponent<Toggle>().isOn&&gameObject.transform.childCount>2)
		{
			//显示物品信息
			LoadItemMessage(gameObject.transform.GetChild(2).name.ToString());
		}
	}

	//使用物品或者销毁物品
	public void Use()
	{
		if(m_ItemDescribe.transform.GetChild(1).childCount!=0&&gameObject.GetComponent<Toggle>().isOn&&gameObject.transform.childCount>2)
		{
			if(1<=int.Parse(m_ItemDescribe.transform.GetChild(4).GetComponent<Text>().text))
			{
				ItemsRefresh.Instance.FindItem(m_ItemDescribe.transform.GetChild(2).GetComponent<Text>().text).number -= 1;
				ItemsRefresh.Instance.ReWrite();
				m_ItemDescribe.transform.GetChild(4).GetComponent<Text>().text=ItemsRefresh.Instance.FindItem(m_ItemDescribe.transform.GetChild(2).GetComponent<Text>().text).number.ToString();
				gameObject.transform.Find("Text").GetComponent<Text>().text=ItemsRefresh.Instance.FindItem(m_ItemDescribe.transform.GetChild(2).GetComponent<Text>().text).number.ToString();
				//加血操作

			}
		}
	}
	
	public void Destory()
	{
		if(m_ItemDescribe.transform.GetChild(1).childCount!=0&&gameObject.GetComponent<Toggle>().isOn&&gameObject.transform.childCount>2)
		{
			if(1<=int.Parse(m_ItemDescribe.transform.GetChild(4).GetComponent<Text>().text))
			{
				ItemsRefresh.Instance.FindItem(m_ItemDescribe.transform.GetChild(2).GetComponent<Text>().text).number -= 1;
				ItemsRefresh.Instance.ReWrite();
				m_ItemDescribe.transform.GetChild(4).GetComponent<Text>().text=ItemsRefresh.Instance.FindItem(m_ItemDescribe.transform.GetChild(2).GetComponent<Text>().text).number.ToString();
				gameObject.transform.Find("Text").GetComponent<Text>().text=ItemsRefresh.Instance.FindItem(m_ItemDescribe.transform.GetChild(2).GetComponent<Text>().text).number.ToString();
			}
		}
	}

	//显示信息显示栏的信息
    public void LoadItemMessage(string gName)
    {
        Item itemTemp=ItemsRefresh.Instance.FindItem(gName);
		if(itemTemp.number>0)
		{
			GameObject prefabTemp=(GameObject)Instantiate(Resources.Load("Prefabs/"+itemTemp.name));
			prefabTemp.transform.position=m_ItemDescribe.transform.GetChild(1).position;
			prefabTemp.transform.SetParent(m_ItemDescribe.transform.GetChild(1));
        	m_ItemDescribe.transform.GetChild(2).GetComponent<Text>().text=itemTemp.name;
			m_ItemDescribe.transform.GetChild(4).GetComponent<Text>().text=itemTemp.number.ToString();
			m_ItemDescribe.transform.GetChild(5).GetComponent<Text>().text=itemTemp.explain;
		}
    }


}
