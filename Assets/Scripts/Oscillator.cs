using System;
using UnityEngine;
/**
* This component moves its object in an oscillatory motion.
*/
public class Oscillator : MonoBehaviour
{
    [Tooltip("Movment speed in meters per sec")]
    [SerializeField]
    float speed = 5f;
    [SerializeField]
    float acceleration = -1f;
    float mid;
    // Start is called before the first frame update


    void Start()
    {
        Debug.Log("Start");
        mid = transform.position.x;

    }

   
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < mid)
        {            
            acceleration = 1;
        }

        if (transform.position.x > mid)
        {
            acceleration = -1;
        }

        speed = speed + acceleration / 50;
        Vector3 temp = new Vector3((float)(Math.Tan(10) * speed * Time.deltaTime), -1 * acceleration * (float)(Math.Tan(10) * speed * Time.deltaTime), 0);
        transform.position += temp;     
    }

}
