using ZXing;
using System.Collections;
using System.Collections.Generic;
using ZXing.QrCode;
using UnityEngine;
using System;

public class LeitorQR : MonoBehaviour {
    private WebCamTexture camTexture;

    // Use this for initialization
    void Start () {
       // screenRect = new Rect(0, 0, Screen.width, Screen.height);
        camTexture = new WebCamTexture();
        camTexture.requestedWidth = 320;
        camTexture.requestedHeight = 480;

        if (camTexture != null)
        {
            camTexture.Play();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        // drawing the camera on screen
      //  GUI.DrawTexture(screenRect, camTexture, ScaleMode.ScaleToFit);
        // do the reading — you might want to attempt to read less often than you draw on the screen for performance sake
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            // decode the current frame
            var result = barcodeReader.Decode(camTexture.GetPixels32(),camTexture.width, camTexture.height);
            if (result != null)
            {
                Debug.Log("DECODED TEXT FROM QR:"  +result.Text);
            }
        }
        catch (Exception ex) { Debug.LogWarning(ex.Message); }
    }

}
