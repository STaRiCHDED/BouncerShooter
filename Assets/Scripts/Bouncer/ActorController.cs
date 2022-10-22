using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField] 
    private Rigidbody _rigidbody;
    
    private Vector3 _target;

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            var direction = Vector3.Normalize(_target - transform.position);
            _rigidbody.AddForce(direction*_speed);
        }
    }

    public void StartMove(Vector3 point)
    {
        _target = point;
    }
}
