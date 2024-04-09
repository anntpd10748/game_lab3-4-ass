using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    //lab6
    // Start is called before the first frame update
    public Slider slider;
    public Canvas gameOverCanvas;
    private bool isGameOver = false;
    private void Start()
    {
        slider.value = 10f;
        gameOverCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameOver && slider.value <= 0)
        {
            GameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Circle"))
        {
            slider.value--;
        }
        else if (collision.gameObject.CompareTag("weel"))
        {
            slider.value--;
        }
    }
    void GameOver()
    {
        isGameOver = true;
        gameOverCanvas.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}
