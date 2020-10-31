using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;
/**
 *  class that rotate goku
 */

public class Rotator_Soldier : MonoBehaviour
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
