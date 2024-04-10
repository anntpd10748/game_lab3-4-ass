using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fistLevel : MonoBehaviour
{
    //lab8
    public PlayerData playerData;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("PlayerLevel", 0);
        PlayerPrefs.SetInt("PlayerScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
