using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoverable : MonoBehaviour
{
    public event Action OnEnter = delegate { };
    public event Action OnExit = delegate { };

    void OnMouseEnter()
    {
        OnEnter();
    }

    void OnMouseExit()
    {
        OnExit();
    }
}
