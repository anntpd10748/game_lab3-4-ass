using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SkinController : MonoBehaviour
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
        ShowMenu();
        Time.timeScale = 0f;
    }
    public void ShowMenu()
    {
        Skin.SetActive(true);
    }
}
