using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class square3 : MonoBehaviour
{
    public float time3 = 60;
    public Text cdText3;
    // Start is called before the first frame update
    //assignment
    void Start()
    {
        StartCoroutine(Countdown());
    }
    IEnumerator Countdown()
    {
        while (time3 > 0)
        {
            yield return new WaitForSeconds(1);
            time3--;
            cdText3.text = "Time: " + time3.ToString();
        }
        cdText3.text = "time over";
        Loadsence6();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal3 = Input.GetAxis("Horizontal");
        float vertical3 = Input.GetAxis("Vertical");
        Vector3 movement3 = new Vector3(horizontal3, vertical3, 0f).normalized;
        transform.Translate(movement3 * 3f * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("circle3"))
        {
            Vector2 firstPosition3 = new Vector2((float)-8.34, (float)4.33);
            transform.position = firstPosition3;
        }

        if (col.gameObject.name.Equals("finish"))
        {
            Loadsence5();
        }
        if (col.gameObject.name.Equals("box3"))
        {
            Vector2 firstPosition3 = new Vector2((float)-8.34, (float)4.33);
            transform.position = firstPosition3;
        }
        if (col.gameObject.tag.Equals("weel"))
        {
            Vector2 firstPosition3 = new Vector2((float)-8.34, (float)4.33);
            transform.position = firstPosition3;
        }
    }
    public void Loadsence5()
    {
        int currentSenceIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSenceIndex - 1);

    }
    public void Loadsence6()
    {
        int currentSenceIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSenceIndex -2);

    }
}
