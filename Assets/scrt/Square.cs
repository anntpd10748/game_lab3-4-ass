using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Square : MonoBehaviour
{
    public float time = 60;
    public Text cdText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());        
    }
    IEnumerator Countdown()
    {
        while (time >0)
        {
            yield return new WaitForSeconds(1);
            time--;
            cdText.text = "Time: " + time.ToString();
        }
        cdText.text = "time over";
        Loadsence2();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized;
        transform.Translate(movement * 3f * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Circle"))
        {
            Vector2 firstPosition = new Vector2(-7, 2);
            transform.position = firstPosition; 
        }

        if (col.gameObject.name.Equals("Box"))
        {
            Loadsence(); 
        }
        if (col.gameObject.name.Equals("wall"))
        {
            Vector2 firstPosition = new Vector2(-7, 2);
            transform.position = firstPosition;
        }
    }
    public void Loadsence()
    {
        int currentSenceIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSenceIndex + 1);

    }
    public void Loadsence2()
    {
        int currentSenceIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSenceIndex + 2);

    }
}
