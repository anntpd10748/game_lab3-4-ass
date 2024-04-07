using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    //lab7
    public Text scoretext;
    private static score instance;
    public static score Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<score>();
            }
            return instance;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private int score1 = 0;

    public void IncreaseScore(int value)
    {
        score1 += value;
        scoretext.text = "Score: " + score1.ToString();
    }

}
