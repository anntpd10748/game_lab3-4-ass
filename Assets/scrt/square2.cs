using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class square2 : MonoBehaviour
{
    public float time2 = 60;
    public Text cdText2;
    //lab4
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());
    }
    IEnumerator Countdown()
    {
        while (time2 > 0)
        {
            yield return new WaitForSeconds(1);
            time2--;
            cdText2.text = "Time: " + time2.ToString();
        }
        cdText2.text = "time over";
        Loadsence4();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal2 = Input.GetAxis("Horizontal");
        float vertical2 = Input.GetAxis("Vertical");
        Vector3 movement2 = new Vector3(horizontal2, vertical2, 0f).normalized;
        transform.Translate(movement2 * 3f * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Box2"))
        {
           Loadsence3();
        }
        if (col.gameObject.name.Equals("wall2"))
        {
            Vector2 firstPosition2 = new Vector2(-5, -4);
            transform.position = firstPosition2;
        }
        if (col.gameObject.tag.Equals("weel"))
        {
            Vector2 firstPosition2 = new Vector2(-5, -4);
            transform.position = firstPosition2;
        }
    }
    public void Loadsence3()
    {
        int currentSenceIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSenceIndex + 3);

    }
    public void Loadsence4()
    {
        int currentSenceIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSenceIndex + 1);

    }
}
