using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    [SerializeField] 
    private GameObject _bullet;
    [SerializeField]
    private float _bulletVelocity = 60f;
    
    private const float MUZZLE_COORDINATES = 2.5f;
    private float _timeDelay = 2f;
    private float _currentTime;
    
    private void Update()
    {
        _currentTime += Time.deltaTime;
        if(_currentTime > _timeDelay)
        {
            var newBullet = Instantiate(_bullet,transform.position + transform.forward * MUZZLE_COORDINATES,transform.localRotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletVelocity;
            _currentTime = 0f;
        }
    }
}
