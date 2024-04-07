using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle4 : MonoBehaviour
{
    private int direction4 = 1;
    private float movespeed4 = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement4 = new Vector3(0f, direction4, 0f);
        transform.Translate(movement4 * movespeed4 * Time.deltaTime);
        if (transform.position.y >= -0.05f || transform.position.y <= -1.5f)
        {
            direction4 *= -1;
        }
    }
}
