using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondNumber : Number
{
    private const string Tag = "SecondBox";

    void Awake()
    {
        base.Initialize(Tag);
    }
}
