using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomControler : MonoBehaviour
{

    private Camera cam;
    private float targetZoom;
    private float zoomFactor = 3f;
    private float zoomLerpSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        targetZoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        float zoomInput = getZoomInput();

        targetZoom = targetZoom - zoomInput * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, 3f ,25f);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomLerpSpeed);
    }

    private float getZoomInput() {
        float zoomInput = Input.GetAxis("Mouse ScrollWheel");
        if( zoomInput == 0 ) {
            if( Input.GetKeyDown( KeyCode.Equals ) ) {
                zoomInput = 1;
            } else if( Input.GetKeyDown( KeyCode.Minus ) ) {
                zoomInput = -1;
            }
        }
        return zoomInput;
    }
}
