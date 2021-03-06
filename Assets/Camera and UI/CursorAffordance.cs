﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorAffordance : MonoBehaviour
{

    [SerializeField]
    Texture2D walkCursor = null;

    [SerializeField]
    Texture2D targetCursor = null;

    [SerializeField]
    Texture2D errorCursor = null;

    [SerializeField]
    Vector2 cursorHotspot = new Vector2(96, 96);

    CameraRaycaster camRay;


    // Use this for initialization
    void Start()
    {
        camRay = GetComponent<CameraRaycaster>();
        camRay.layerChangeObservers += OnLayerChange;
    }


    void OnLayerChange(Layer newLayer)
    {
        switch (newLayer)
        {
            case Layer.Walkable:
                Cursor.SetCursor(walkCursor, cursorHotspot, CursorMode.Auto);
                break;
            case Layer.Enemy:
                Cursor.SetCursor(targetCursor, cursorHotspot, CursorMode.Auto);
                break;
            default:
                Cursor.SetCursor(errorCursor, cursorHotspot, CursorMode.Auto);
                return;
        }
    }

    //TODO consider deregistering observers on Scene Change
}
