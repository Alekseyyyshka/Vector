using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public GameObject[] interactableObjects;
    public GameObject UiPanel;

    private Camera _mainCamera;
    private GameObject _selectObject;

    // Start is called before the first frame update
    void Start()
    {
        _mainCamera= Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit;

            Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit)) 
            {
                GameObject hitObject = hit.collider.gameObject;

                if (Array.Exists(interactableObjects, obj => obj == hitObject))
                    SelectObject(hitObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            SetObjectTransparency(_selectObject, 0.5f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            ChangeObjectColor(_selectObject, Color.blue);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
           HideObject(_selectObject);
        }
    }

    private void SelectObject(GameObject obj) 
    {
        _selectObject = obj;
        UiPanel.SetActive(true);
    }

    private void SetObjectTransparency(GameObject obj, float transparency) 
    { 
        Renderer renderer = obj.GetComponent<Renderer>();
        Color color = renderer.material.color;
        color.a = transparency;
        renderer.material.color = color;
    }

    private void ChangeObjectColor(GameObject obj, Color color) 
    {
        Renderer renderer = obj.GetComponent<Renderer>();   
        renderer.material.color = color;
    }

    private void HideObject(GameObject obj) 
    { 
        obj.SetActive(false);
    }

}
