using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemUseAndDestory : MonoBehaviour {

	[SerializeField]private GameObject m_ItemDescribe;
	[SerializeField]private Button useButton;
	[SerializeField]private Button deleteButton;
	// Use this for initialization
	void Start () {
		useButton.onClick.AddListener(
            delegate () {
                // 这里添加你想要监听的事件
                Use();
            }
        );
		deleteButton.onClick.AddListener(
            delegate () {
                // 这里添加你想要监听的事件
                Destory();
            }
        );
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
