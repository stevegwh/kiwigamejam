using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    [SerializeField]
    private float _currentVelocity = 0f;
    private float _initialVelocity = 2f;
    private float _finalVelocity = 10f;
    private readonly float accelerationRate = 0.2f;
    private readonly float decelerationRate = 50.0f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //ensure the velocity never goes out of the initial/final boundaries
        if (Input.GetKey(KeyCode.Space))
        {
            _currentVelocity += accelerationRate * Time.deltaTime;
            _currentVelocity = Mathf.Clamp(_currentVelocity, _initialVelocity, _finalVelocity);
        }
        else
        {
            _currentVelocity = 0f;
        }
        rb.AddForce(transform.up * (_currentVelocity * accelerationRate));

    }
}
