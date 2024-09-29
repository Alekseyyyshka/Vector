using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFullTransform : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotateY;
    [SerializeField] private float _speedByScale;

    void Update()
    {
        MoveForvard();

        RotateByY();

        Scale();
    }

    private void MoveForvard()
    {
        transform.position += transform.forward * _speedMove * Time.deltaTime;
    }

    private void RotateByY()
    {
        transform.Rotate(0, _speedRotateY * Time.deltaTime, 0);
    }

    private void Scale() 
    {
        transform.localScale += new Vector3(_speedByScale, _speedByScale, _speedByScale);
    }
}
