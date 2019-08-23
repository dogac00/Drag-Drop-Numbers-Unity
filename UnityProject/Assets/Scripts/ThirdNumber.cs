using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdNumber : Number
{
    private const string Tag = "ThirdBox";

    void Awake()
    {
        base.Initialize(Tag);
    }
}
