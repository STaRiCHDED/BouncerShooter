using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorHandler : MonoBehaviour
{
    [SerializeField] 
    private Material[] _colors;

    private Renderer _currentRenderer;
    private void Awake()
    {
        _currentRenderer = GetComponent<Renderer>();
        _currentRenderer.material.color = GenerateNewColor();
    }

    private Color GenerateNewColor()
    {
        var elem = Random.Range(0, _colors.Length);
        return _colors[elem].color;
    }
    public void ChangeColor()
    {
        _currentRenderer.material.color = GenerateNewColor();
    }
    
}
