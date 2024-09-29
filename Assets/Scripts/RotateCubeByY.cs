using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RotateCubeByY : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        RotateCube();
    }

    private void RotateCube()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
