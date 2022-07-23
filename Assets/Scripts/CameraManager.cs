using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject Loop;

    private float initialX;
    private float initialY;
    private float initialZ;


    // Start is called before the first frame update
    void Start()
    {
        initialX = transform.position.x;
        initialY = transform.position.y;
        initialZ = transform.position.z;

    }

    // Update is called once per frame
    void Update()
    { 
        transform.position = new Vector3(initialX + Loop.transform.position.x, Loop.transform.position.y, Loop.transform.position.z);

    }
}
