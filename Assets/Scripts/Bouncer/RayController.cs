using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour
{
    [SerializeField]
    private ActorController _actor;
    [SerializeField]
    private LayerMask _layer;

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out var rayInfo,100f,_layer))
        {
            if (Input.GetMouseButtonDown(0))
            {
                var point = rayInfo.point;
                _actor.StartMove(point);
            }
        }
    }
}
