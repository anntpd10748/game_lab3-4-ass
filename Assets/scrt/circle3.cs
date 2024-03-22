using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle3 : MonoBehaviour
{

    private int direction3 = 4;
    private float movespeed3 = 1;
    // Start is called before the first frame update
    //assignment
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement3 = new Vector3(0f, direction3, 0f);
        transform.Translate(movement3 * movespeed3 * Time.deltaTime);
        if (transform.position.y >= 3.5f || transform.position.y <= -3.5f)
        {
            direction3 *= -1;
        }
    }
}
