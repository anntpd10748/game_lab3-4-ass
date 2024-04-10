using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public PlayerData playerData;
    //lab7
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public int scoreValue = 10;
    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Circle"))
        {
            //lab8
            playerData.playerScore++;
            PlayerPrefs.SetInt("PlayerScore", playerData.playerScore);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag.Equals("weel"))
        {
            //lab8
            playerData.playerScore++;
            PlayerPrefs.SetInt("PlayerScore", playerData.playerScore);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag.Equals("wall4"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name.Equals("finish"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name.Equals("box3"))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("wall4"))
        {
            Destroy(gameObject);
        }
    }
}
