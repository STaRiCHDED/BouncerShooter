using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] 
    private float _rotationSpeed;
    [SerializeField] 
    private float _speed;
    void Update()
    {
        var rotation = transform.rotation;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * _speed);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0,1* Time.deltaTime * _rotationSpeed,0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1 * Time.deltaTime* _rotationSpeed, 0);
        }
    }
}
