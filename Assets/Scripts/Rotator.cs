using System.Collections;
using Unity.Mathematics;
using UnityEngine;
/**
 *  class that rotate goku
 */

public class Rotator : MonoBehaviour
{
    [Tooltip("rotation speed")]
    [SerializeField]
    float RotateSpeed;
    float RotateZ;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        RotateZ += Time.deltaTime * RotateSpeed;
        transform.rotation = quaternion.Euler(0,0,RotateZ);
        

    }
}
