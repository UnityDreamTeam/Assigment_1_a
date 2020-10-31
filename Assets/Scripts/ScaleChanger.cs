using UnityEngine;
/**
 * This script expands and shrinks object size in a heartbeat motion.
 * */
public class ScaleChanger : MonoBehaviour
{
    private float d = 1f;
    Vector3 temp;

    // Start is called before the first frame update
    void Start()
	{

    }
    // Update is called once per frame
    void Update()
    {
        temp = transform.localScale;
        transform.localScale += temp * d * Time.deltaTime;

        if (transform.localScale.x > 2 || transform.localScale.y > 2)
            d = -1;
        if (transform.localScale.x < 1 || transform.localScale.y < 1)
            d = 1;

    }
}
