using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public static class GameObjectUtility
{
    public static GameObject FindObjectByTag(string tag)
    {
        foreach (GameObject go in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
        {
            if (go.hideFlags == HideFlags.NotEditable || go.hideFlags == HideFlags.HideAndDontSave)
                continue;

            if (go.tag == tag) return go;
        }

        return null;
    }

    public static GameObject FindObjectByName(string name)
    {
        return Resources.FindObjectsOfTypeAll(typeof(GameObject)).Cast<GameObject>().FirstOrDefault(go => go.name == name);
    }
}
