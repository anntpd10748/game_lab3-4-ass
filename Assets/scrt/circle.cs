using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    private int direction = 1;
    private float movespeed = 3;
    // Start is called before the first frame update
//lab3
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0f, direction, 0f);
        transform.Translate(movement * movespeed * Time.deltaTime);
        if(transform.position.y>=1.65f || transform.position.y<= -1.65f)
        {
            direction *= -1;
        }
    }
}
