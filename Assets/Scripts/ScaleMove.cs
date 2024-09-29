using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
        ScaleObject();
    }

    private void ScaleObject() 
    {
        transform.localScale += new Vector3(_speed,_speed,_speed);
    }
}
