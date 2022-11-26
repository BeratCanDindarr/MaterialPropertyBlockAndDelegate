using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ClickedManager : MonoBehaviour
{
    public delegate void _colorChange();
    public static event _colorChange setColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            setColor?.Invoke();
        }
    }
}
