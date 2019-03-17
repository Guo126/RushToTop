using UnityEngine;
using UnityEngine.UI;

public class mouseStyle :MonoBehaviour
{
    public Texture mouse;
    public RawImage image1, image2;

    private void Start()
    {
        Invoke("startGame", 15f);
    }

    void Update()
    {
        Cursor.visible = false;//隐藏鼠标指针
    }
    void OnGUI()
    {
        Vector2 msPos=Input.mousePosition;//鼠标的位置
        GUI.DrawTexture(new Rect(msPos.x, Screen.height-msPos.y,35,35),mouse);
    }

    void startGame()
    {
        image1.gameObject.SetActive(false);
        image2.gameObject.SetActive(false);
    }

    private void OnApplicationQuit()
    {
        
    }

    public void Destroy()
    {
        Application.Quit();

    }

}

