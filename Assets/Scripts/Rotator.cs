using System.Collections;
using UnityEngine;
/**
 *  class that rotate goku
 */

public class Rotator : MonoBehaviour
{
    [Tooltip("rotation speed")]
    [SerializeField]
    float RotateSpeed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(0, RotateSpeed, 0);
       
    }
}
