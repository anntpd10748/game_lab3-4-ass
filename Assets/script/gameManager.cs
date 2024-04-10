using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    //lab8
    public PlayerData playerData;
    // Start is called before the first frame update
    void Start()
    {
        if (playerData == null)
        {
            playerData = ScriptableObject.CreateInstance<PlayerData>();
            playerData.playerLevel = 0;
            playerData.playerScore = 0;
        }
        else
        {
            LoadPlayerData();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadPlayerData()
    {
        if (PlayerPrefs.HasKey("PlayerLevel"))
        {
            playerData.playerLevel = PlayerPrefs.GetInt("PlayerLevel");
            playerData.playerScore = PlayerPrefs.GetInt("PlayerScore");
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
