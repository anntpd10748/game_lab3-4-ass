using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    //lab5
    // Start is called before the first frame update
    public GameObject menuCanvas;
    public GameObject menuSkin;
    public PlayerData playerData;
    public Text Level;
    public Text Score;
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
                LoadPlayerData();
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
    //lab8
     void LoadPlayerData()
    {
        if (PlayerPrefs.HasKey("PlayerLevel"))
        {
            Debug.Log("load menu");
            playerData.playerLevel = PlayerPrefs.GetInt("PlayerLevel");
            playerData.playerScore = PlayerPrefs.GetInt("PlayerScore");
            Level.text = "level: " + (playerData.playerLevel).ToString();
            Score.text = "socre: " + (playerData.playerScore).ToString();
            Debug.Log("PlayerLevel" + playerData.playerLevel);
            Debug.Log("PlayerScore" + playerData.playerScore);
        }
        else
        {
            playerData.playerLevel = 0;
            playerData.playerScore = 0;
        }
    }
}
