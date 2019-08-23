using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    private bool _drag;
    private Camera _mainCamera;

    private Vector3 _firstPosition;

    protected void Start()
    {
        _mainCamera = Camera.main;
        _firstPosition = this.transform.position;
        _drag = false;
    }

    void OnMouseDown()
    {
        _drag = true;
    }

    void OnMouseDrag()
    {
        if (_drag)
        {
            Vector3 currentPos = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = new Vector3(currentPos.x + 0.4F, currentPos.y, 0);
        }
    }

    protected virtual void OnMouseUp()
    {
        _drag = false;
    }

    protected void GoBack()
    {
        this.transform.position = new Vector3(_firstPosition.x, _firstPosition.y);
    }
}
