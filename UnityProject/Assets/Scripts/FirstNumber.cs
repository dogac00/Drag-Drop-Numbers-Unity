using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstNumber : Number
{
    private const string Tag = "FirstBox";

    void Awake()
    {
        base.Initialize(Tag);
    }
}
