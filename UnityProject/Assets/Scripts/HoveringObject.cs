using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoveringObject : MonoBehaviour
{
    private Camera _main;

    public static GameObject Instance;

    void Awake()
    {
        Instance = this.gameObject;

        this.gameObject.SetActive(false);

        _main = Camera.main;

        foreach (GameObject go in Resources.FindObjectsOfTypeAll<GameObject>())
        {
            print(go.name);

            if (go.gameObject.GetComponent<Draggable>() != null && go.gameObject.GetComponent<Hoverable>() != null)
            {
                go.gameObject.GetComponent<Hoverable>().OnEnter += OnEnter;
                go.gameObject.GetComponent<Hoverable>().OnExit += OnExit;
            }
        }
    }

    void OnEnter()
    {
        if (HoldingObject.IsHolding) return;

        Cursor.visible = false;

        this.gameObject.SetActive(true);
    }

    void OnExit()
    {
        if (HoldingObject.IsHolding) return;

        Cursor.visible = true;

        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = _main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(currentPos.x + 0.4F, currentPos.y, 0);
    }
}
