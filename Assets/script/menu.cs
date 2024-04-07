using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    //lab5
    // Start is called before the first frame update
    public GameObject menuCanvas;
    public GameObject menuSkin;
    void Start()
    {
        HideMenu();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (menuCanvas.activeSelf)
            {
                HideMenu();
            }
            else
            {
                ShowMenu();
            }
        }
    }

    void ShowMenu()
    {
        menuCanvas.SetActive(true);
        Time.timeScale = 0f; // Dừng thời gian trong trò chơi khi hiển thị menu
    }

    void HideMenu()
    {
        menuCanvas.SetActive(false);
        menuSkin.SetActive(false);
        Time.timeScale = 1f; // Khôi phục thời gian khi ẩn menu
    }
}
