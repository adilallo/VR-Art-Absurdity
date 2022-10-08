using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IPDadjust : MonoBehaviour
{
    public GameObject parent;
    public Transform left;
    public Transform right;

    public KeyCode widen;
    public KeyCode narrow;

    // Start is called before the first frame update
    void Start()
    {
    left = parent.transform.Find("LeftEye");
    right = parent.transform.Find("RightEye");
    }

    // Update is called once per frame
    void Update()
    {
        //widens IPD by 1 mm
        if (Input.GetKeyDown(widen)) 
        {
            left.position += new Vector3(-0.001f,0.0f,0.0f);
            right.position += new Vector3(0.001f,0.0f,0.0f);
        }

        //narrows IPD by 1 mm
        if (Input.GetKeyDown(narrow)) 
        {
            left.position += new Vector3(0.001f,0f,0f);
            right.position += new Vector3(-0.001f,0f,0f);
        }
            
    }
}
