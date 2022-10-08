using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCameras : MonoBehaviour
{

    public Camera cameraM;
    public GameObject cameraB;
    private Camera left;
    private Camera right;

    public KeyCode swapCams;

    // Start is called before the first frame update
    void Start()
    {
        left =  cameraB.transform.Find("LeftEye").gameObject.GetComponent<Camera>();
        right =  cameraB.transform.Find("RightEye").gameObject.GetComponent<Camera>();

        cameraM.enabled = true;
        left.enabled = false;
        right.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(swapCams))
        {
            cameraM.enabled = !cameraM.enabled;
            left.enabled = !left.enabled;
            right.enabled = !right.enabled;
        }
    }
}
