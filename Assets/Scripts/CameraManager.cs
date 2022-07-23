using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Rigidbody Loop;

    private float initialY;

    private Vector3 rotateValue;

    [SerializeField]
    private float rotation;
    // Start is called before the first frame update
    void Start()
    {
        initialY = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    { 
        transform.position = new Vector3(transform.position.x, initialY + Loop.transform.position.y, transform.position.z);

        rotation -= 0.1f;
        transform.eulerAngles = new Vector3(0, 0, rotation);
    }
}
