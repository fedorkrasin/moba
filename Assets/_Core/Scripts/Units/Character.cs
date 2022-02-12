using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Unit
{
    private void OnMouseDown()
    {
        Debug.Log(_health.GetHealth());
    }
}
