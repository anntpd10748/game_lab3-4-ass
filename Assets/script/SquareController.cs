using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SquareController : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRemaining = 60;
    public Text countdownText;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public PlayerData playerData;
    private Vector2 shootDirection;
    void Start()
    {
        StartCoroutine(Countdown());
        bulletSpeed = 10f;
    }
    IEnumerator Countdown()
    {
        while (timeRemaining > 0)
        {
            yield return new WaitForSeconds(1);
            timeRemaining--;
            countdownText.text = "Time: " + timeRemaining.ToString();
        }
        countdownText.text = "Time's up!";
        loadsence();
    }
    // Update is called once per frame
    void Update()
    {
        //lab7
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            shootDirection = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            shootDirection = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            shootDirection = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            shootDirection = Vector2.down;
        }

        //lab7
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, moveDirection, out hit, 1.0f))
        {
            Renderer renderer = hit.collider.GetComponent<Renderer>();

            if (renderer != null && renderer.material.color == Color.black)
            {
                
                transform.Translate(-moveDirection * moveSpeed * Time.deltaTime);
            }
        }


    }
    public void LoadNextScene()
    {
        
        playerData.playerLevel++;
        // l�u th�ng tin playerLevel v�o PlayerPrefs
        PlayerPrefs.SetInt("PlayerLevel", playerData.playerLevel);
        PlayerPrefs.SetInt("PlayerScore", playerData.playerScore);

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Circle"))
        {

            Vector2 fistPosition = new Vector2(-7, 1);
            transform.position = fistPosition;

        }
        if (collision.gameObject.tag.Equals("finish"))
        {

            LoadNextScene();

        }
        if (collision.gameObject.tag.Equals("weel"))
        {

            Vector2 fistPosition = new Vector2(-7, 1);
            transform.position = fistPosition;

        }
        if (collision.gameObject.tag.Equals("wall4"))
        {

            Vector2 fistPosition = new Vector2(-7, 1);
            transform.position = fistPosition;
        }


    }
    void Shoot()
    {
        //lab7
        GameObject newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody2D bulletRb = newBullet.GetComponent<Rigidbody2D>();
        if (bulletRb != null)
        {

            bulletRb.velocity = shootDirection * bulletSpeed;  
        }
    }
    public void loadsence()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 5);
    }

}