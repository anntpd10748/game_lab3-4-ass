using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    //lab5
    public GameObject Skin;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.UI.Button button = GetComponent<UnityEngine.UI.Button>();
        button.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnClick()
    {
        HideMenu();
        Time.timeScale = 1f;
    }
    void HideMenu()
    {
        Skin.SetActive(false);
    }
}
