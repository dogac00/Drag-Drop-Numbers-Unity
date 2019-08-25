using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holdable : MonoBehaviour
{
    public event Action MouseDown = delegate { };
    public event Action MouseUp = delegate { };

    void OnMouseDown()
    {
        MouseDown();
    }

    void OnMouseUp()
    {
        MouseUp();
    }
}
