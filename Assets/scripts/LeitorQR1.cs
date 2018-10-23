using ZXing;
using System.Collections;
using System.Collections.Generic;
using ZXing.QrCode;
using UnityEngine;
using System;
using UnityEngine.UI;

public class LeitorQR1 : MonoBehaviour {
    private WebCamTexture camTexture;
    public int fps=5;
    private Rect screenRect;
    RawImage rawImage;
    public GameObject posicaoAtual;
    Transform transformAtual;
    Transform transformProx;
    Transform transformProx2;

    public GameObject posicaoProx;
    public GameObject posicaoProx2;
    // Use this for initialization
    void Start () {

        transformAtual = posicaoAtual.GetComponent<Transform>();
        transformProx = posicaoProx.GetComponent<Transform>();
        transformProx2 = posicaoProx2.GetComponent<Transform>();

        rawImage = GetComponent<RawImage>();
        camTexture = new WebCamTexture();
        camTexture.requestedWidth = 320;
        camTexture.requestedHeight = 480;
        
        if (camTexture != null)
        {
           
            camTexture.Play();
            rawImage.texture = camTexture;
        }
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
            var result = barcodeReader.Decode(camTexture.GetPixels32(),
              camTexture.width, camTexture.height);
            if (result != null)
            {
                 Debug.Log("DECODED TEXT FROM QR:"  +result.Text);
                if (result.Text == "1")
                {
                 //   print("atualiza");
                    transformAtual.position = transformProx.position;
                }else if(result.Text == "2")
                {
                    transformAtual.position = transformProx2.position;

                }
            }
        }
        catch (Exception ex) { Debug.LogWarning(ex.Message); }
    }

}
