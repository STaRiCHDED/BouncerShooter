using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SphereController : MonoBehaviour
{
    private ColorHandler _colorHandler;
    

    private void Awake()
    {
        _colorHandler = gameObject.GetComponent<ColorHandler>();
    }

    private void OnTriggerEnter(Collider other)
    {
        var colliderObject = other.gameObject.GetComponent<Renderer>();
        var current = gameObject.GetComponent<Renderer>();
        colliderObject.material.color = current.material.color;
        gameObject.transform.position = new Vector3(Random.Range(-20,20), gameObject.transform.localScale.y, Random.Range(-20,20));
        _colorHandler.ChangeColor();
    }
}
