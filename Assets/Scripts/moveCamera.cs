using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetKey("w")){
    		transform.Translate(0, 0, 0.001f);
    	}
        if(Input.GetKey("a")){
            transform.Translate(-0.001f, 0, 0);
        }
        if(Input.GetKey("s")){
            transform.Translate(0, 0, -0.001f);
        }
        if(Input.GetKey("d")){
            transform.Translate(0.001f, 0, 0);
        }
         if(Input.GetKey("e")){
            transform.Translate(0, 0.001f, 0);
        }
         if(Input.GetKey("x")){
            transform.Translate(0, -0.001f, 0);
        }
        if(Input.GetKey("c")){
            transform.Rotate(0.0f, 0.008f, 0.0f, Space.Self);
        }
        if(Input.GetKey("z")){
            transform.Rotate(0.0f, -0.008f, 0.0f, Space.Self);
        }
        
    }
}
