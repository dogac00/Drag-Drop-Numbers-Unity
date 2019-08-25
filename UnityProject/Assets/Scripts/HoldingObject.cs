using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingObject : MonoBehaviour
{
    private Camera _main;

    public static bool IsHolding;

    void Awake()
    {
        this.gameObject.SetActive(false);

        _main = Camera.main;

        foreach (GameObject go in Resources.FindObjectsOfTypeAll<GameObject>())
        {
            if (go.gameObject.GetComponent<Holdable>() != null)
            {
                go.gameObject.GetComponent<Holdable>().MouseUp += OnUp;
                go.gameObject.GetComponent<Holdable>().MouseDown += OnDown;
            }
        }
    }

    void OnUp()
    {
        IsHolding = false;

        Cursor.visible = true;

        this.gameObject.SetActive(false);
    }

    void OnDown()
    {
        IsHolding = true;

        HoveringObject.Instance.SetActive(false);

        Cursor.visible = false;

        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = _main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(currentPos.x + 0.4F, currentPos.y, 0);
    }
}
