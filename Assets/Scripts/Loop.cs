using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    private float _initialVelocity = 0f;
    private float _finalVelocity = 10f;
    [SerializeField]
    private float _currentVelocity = 0f;
    private readonly float accelerationRate = 0.1f;
    private Rigidbody rb;
    [SerializeField]
    private float rotation;

    private Vector3 worldPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rotation = transform.parent.eulerAngles.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _currentVelocity += accelerationRate;
        }
        else
        {
            _currentVelocity -= accelerationRate;
        }
        transform.parent.position += transform.parent.forward * Time.deltaTime * _currentVelocity;
        _currentVelocity = Mathf.Clamp(_currentVelocity, _finalVelocity * -1, _finalVelocity);

        if (Input.GetKey(KeyCode.Alpha9))
        {
            Debug.Log("Number pressed!");
            rotation -= 0.1f;
        } else if (Input.GetKey(KeyCode.Alpha0))
        {
            rotation += 0.1f;
        }
        transform.parent.eulerAngles = new Vector3(rotation, 0, 0);
        //transform.parent.position -= transform.parent.forward * Time.deltaTime * gravity;
        //transform.position = new Vector3(transform.position.x, (transform.forward * _currentVelocity).y, transform.position.z);
        //rb.AddForce(transform.up * (_currentVelocity * accelerationRate));
        //Vector3 mousePos = Input.mousePosition;
        //mousePos.z = Camera.main.nearClipPlane;
        //worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
        //transform.position = new Vector3(worldPosition.x, transform.position.y, transform.position.z);
    }
}
