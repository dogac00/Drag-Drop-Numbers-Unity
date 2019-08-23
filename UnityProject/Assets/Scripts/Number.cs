using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : Draggable
{
    private bool _isInTrigger;
    private string _colliderTag;

    private static GameObject _successPanel;
    private static int _total;

    protected void Initialize(string colTag)
    {
        _colliderTag = colTag;
        _successPanel = GameObjectUtility.FindObjectByName("Panel");

        base.Start();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == _colliderTag)
        {
            _isInTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == _colliderTag)
        {
            _isInTrigger = false;
        }
    }

    protected override void OnMouseUp()
    {
        base.OnMouseUp();

        if (!_isInTrigger)
        {
            _total--;
            base.GoBack();
        }
        else
        {
            _total++;

            if (_total == 3) _successPanel.SetActive(true);
        }
    }
}
