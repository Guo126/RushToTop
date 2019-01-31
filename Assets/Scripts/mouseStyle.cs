using UnityEngine;
using UnityEngine.UI;

public class mouseStyle :MonoBehaviour
{
    public Texture mouse;

    void Update()
    {
        Cursor.visible = false;//隐藏鼠标指针
    }
    void OnGUI()
    {
        Vector2 msPos=Input.mousePosition;//鼠标的位置
        GUI.DrawTexture(new Rect(msPos.x, Screen.height-msPos.y,35,35),mouse);
    }
}

