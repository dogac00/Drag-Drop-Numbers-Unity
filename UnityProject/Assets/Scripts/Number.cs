using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : Draggable
{
    private string _colliderTag;

    private static GameObject _successPanel;
    private static int _total;

    protected override void Start()
    {
        _colliderTag = string.Empty;
        _successPanel = GameObjectUtility.FindObjectByName("Panel");

        base.Start();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (this.tag == collider.tag)
        {
            _colliderTag = collider.tag;
            _total++;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (this.tag == collider.tag)
        {
            _colliderTag = string.Empty;
            _total--;
        }
    }

    protected override void OnMouseUp()
    {
        base.OnMouseUp();

        if (this.tag != _colliderTag)
        {
            base.GoBack();
        }
        else
        {
            if (_total == 3)
            {
                _successPanel.SetActive(true);

                _total = 100;
            }
        }
    }
}
