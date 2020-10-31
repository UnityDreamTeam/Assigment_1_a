using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * class that control the treasure display on spacebar key push
 */

public class HideAndShow : MonoBehaviour
{   SpriteRenderer display;
    // Start is called before the first frame update
    void Start()
    {
        this.display = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) {
            if (this.display.enabled)
            {
            this.display.enabled = false;
            }
            else
            {
                this.display.enabled = true;
            }
        }
        
    }
}
