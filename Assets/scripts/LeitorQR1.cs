using ZXing;
using System.Collections;
using System.Collections.Generic;
using ZXing.QrCode;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.AI;

public class LeitorQR1 : MonoBehaviour {
    private WebCamTexture camTexture;
    public int fps=5;
    private Rect screenRect;
    RawImage rawImage;
    public GameObject posicaoAtual;
    Transform transformAtual;
    private float Cronometro = 0;
    public NavMeshAgent pessoaAgent;
    public Transform[] A;
    public Transform[] B;
    public Transform[] C;
    public Transform[] D;
    public Transform[] E;
    public Transform[] F;
    public Transform[] G;
    public Transform[] H;
    public Transform[] I;
    public Transform[] J;

    void Start () {

        transformAtual = posicaoAtual.GetComponent<Transform>();

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

    public void CompararResultado(String resultado)
    {
       // Debug.Log("teste0");
        if(resultado[0] == 'A'  || resultado[0]=='a'){
         //   Debug.Log("teste1");
            if (resultado[1] == '0')
            {
                transformAtual.position = A[0].position;
            }
            else if (resultado[1] == '1')
            {
                transformAtual.position = A[1].position;
            }
            else if (resultado[1] == '2')
            {
                transformAtual.position = A[2].position;
            }
            else if (resultado[1] == '3')
            {
                transformAtual.position = A[3].position;
            }
            else if (resultado[1] == '4')
            {
                transformAtual.position = A[4].position;
            }
            else if (resultado[1] == '5')
            {
                transformAtual.position = A[5].position;
            }
            else if (resultado[1] == '6')
            {
                transformAtual.position = A[6].position;
            }
            else if (resultado[1] == '7')
            {
                transformAtual.position = A[7].position;
            }
            else if (resultado[1] == '8')
            {
                transformAtual.position = A[8].position;
            }
            else if (resultado[1] == '9')
            {
                transformAtual.position = A[9].position;
            }
        }
        else if (resultado[0] == 'B' || resultado[0] == 'b')
        {
            if (resultado[1] == '0')
            {
                transformAtual.position = B[0].position;
            }
            else if (resultado[1] == '1')
            {
                transformAtual.position = B[1].position;
            }
            else if (resultado[1] == '2')
            {
                transformAtual.position = B[2].position;
            }
            else if (resultado[1] == '3')
            {
                transformAtual.position = B[3].position;
            }
            else if (resultado[1] == '4')
            {
                transformAtual.position = B[4].position;
            }
            else if (resultado[1] == '5')
            {
                transformAtual.position = B[5].position;
            }
            else if (resultado[1] == '6')
            {
                transformAtual.position = A[6].position;
            }
            else if (resultado[1] == '7')
            {
                transformAtual.position = B[7].position;
            }
            else if (resultado[1] == '8')
            {
                transformAtual.position = B[8].position;
            }
            else if (resultado[1] == '9')
            {
                transformAtual.position = B[9].position;
            }
        }
        else if (resultado[0] == 'C' || resultado[0] == 'c')
        {
            if (resultado[1] == '0')
            {
                transformAtual.position = C[0].position;
            }
            else if (resultado[1] == '1')
            {
                transformAtual.position = C[1].position;
            }
            else if (resultado[1] == '2')
            {
                transformAtual.position = C[2].position;
            }
            else if (resultado[1] == '3')
            {
                transformAtual.position = C[3].position;
            }
            else if (resultado[1] == '4')
            {
                transformAtual.position = C[4].position;
            }
            else if (resultado[1] == '5')
            {
                transformAtual.position = C[5].position;
            }
            else if (resultado[1] == '6')
            {
                transformAtual.position = C[6].position;
            }
            else if (resultado[1] == '7')
            {
                transformAtual.position = C[7].position;
            }
            else if (resultado[1] == '8')
            {
                transformAtual.position = C[8].position;
            }
            else if (resultado[1] == '9')
            {
                transformAtual.position = C[9].position;
            }
        }
        else if (resultado[0] == 'D' || resultado[0] == 'd')
        {
            if (resultado[1] == '0')
            {
                transformAtual.position = D[0].position;
            }
            else if (resultado[1] == '1')
            {
                transformAtual.position = D[1].position;
            }
            else if (resultado[1] == '2')
            {
                transformAtual.position = D[2].position;
            }
            else if (resultado[1] == '3')
            {
                transformAtual.position = D[3].position;
            }
            else if (resultado[1] == '4')
            {
                transformAtual.position = D[4].position;
            }
            else if (resultado[1] == '5')
            {
                transformAtual.position = D[5].position;
            }
            else if (resultado[1] == '6')
            {
                transformAtual.position = D[6].position;
            }
            else if (resultado[1] == '7')
            {
                transformAtual.position = D[7].position;
            }
            else if (resultado[1] == '8')
            {
                transformAtual.position = D[8].position;
            }
            else if (resultado[1] == '9')
            {
                transformAtual.position = D[9].position;
            }
        }
        else if (resultado[0] == 'E' || resultado[0] == 'e')
        {
            if (resultado[1] == '0')
            {
                transformAtual.position = E[0].position;
            }
            else if (resultado[1] == '1')
            {
                transformAtual.position = E[1].position;
            }
            else if (resultado[1] == '2')
            {
                transformAtual.position = E[2].position;
            }
            else if (resultado[1] == '3')
            {
                transformAtual.position = E[3].position;
            }
            else if (resultado[1] == '4')
            {
                transformAtual.position = E[4].position;
            }
            else if (resultado[1] == '5')
            {
                transformAtual.position = E[5].position;
            }
            else if (resultado[1] == '6')
            {
                transformAtual.position = E[6].position;
            }
            else if (resultado[1] == '7')
            {
                transformAtual.position = E[7].position;
            }
            else if (resultado[1] == '8')
            {
                transformAtual.position = E[8].position;
            }
            else if (resultado[1] == '9')
            {
                transformAtual.position = E[9].position;
            }
        }
        else if (resultado[0] == 'F' || resultado[0] == 'f')
        {
            if (resultado[1] == '0')
            {
                transformAtual.position = F[0].position;
            }
            else if (resultado[1] == '1')
            {
                transformAtual.position = F[1].position;
            }
            else if (resultado[1] == '2')
            {
                transformAtual.position = F[2].position;
            }
            else if (resultado[1] == '3')
            {
                transformAtual.position = F[3].position;
            }
            else if (resultado[1] == '4')
            {
                transformAtual.position = F[4].position;
            }
            else if (resultado[1] == '5')
            {
                transformAtual.position = F[5].position;
            }
            else if (resultado[1] == '6')
            {
                transformAtual.position = F[6].position;
            }
            else if (resultado[1] == '7')
            {
                transformAtual.position = F[7].position;
            }
            else if (resultado[1] == '8')
            {
                transformAtual.position = F[8].position;
            }
            else if (resultado[1] == '9')
            {
                transformAtual.position = F[9].position;
            }
        }
        else if (resultado[0] == 'G' || resultado[0] == 'g')
        {
            if (resultado[1] == '0')
            {
                transformAtual.position = G[0].position;
            }
            else if (resultado[1] == '1')
            {
                transformAtual.position = G[1].position;
            }
            else if (resultado[1] == '2')
            {
                transformAtual.position = G[2].position;
            }
            else if (resultado[1] == '3')
            {
                transformAtual.position = G[3].position;
            }
            else if (resultado[1] == '4')
            {
                transformAtual.position = G[4].position;
            }
            else if (resultado[1] == '5')
            {
                transformAtual.position = G[5].position;
            }
            else if (resultado[1] == '6')
            {
                transformAtual.position = G[6].position;
            }
            else if (resultado[1] == '7')
            {
                transformAtual.position = G[7].position;
            }
            else if (resultado[1] == '8')
            {
                transformAtual.position = G[8].position;
            }
            else if (resultado[1] == '9')
            {
                transformAtual.position = G[9].position;
            }
        }
        else if (resultado[0] == 'H' || resultado[0] == 'h')
        {
            if (resultado[1] == '0')
            {
                transformAtual.position = H[0].position;
            }
            else if (resultado[1] == '1')
            {
                transformAtual.position = H[1].position;
            }
            else if (resultado[1] == '2')
            {
                transformAtual.position = H[2].position;
            }
            else if (resultado[1] == '3')
            {
                transformAtual.position = H[3].position;
            }
            else if (resultado[1] == '4')
            {
                transformAtual.position = H[4].position;
            }
            else if (resultado[1] == '5')
            {
                transformAtual.position = H[5].position;
            }
            else if (resultado[1] == '6')
            {
                transformAtual.position = H[6].position;
            }
            else if (resultado[1] == '7')
            {
                transformAtual.position = H[7].position;
            }
            else if (resultado[1] == '8')
            {
                transformAtual.position = H[8].position;
            }
            else if (resultado[1] == '9')
            {
                transformAtual.position = H[9].position;
            }
        }
        else if (resultado[0] == 'I' || resultado[0] == 'i')
        {
            if (resultado[1] == '0')
            {
                transformAtual.position = I[0].position;
            }
            else if (resultado[1] == '1')
            {
                transformAtual.position = I[1].position;
            }
            else if (resultado[1] == '2')
            {
                transformAtual.position = I[2].position;
            }
            else if (resultado[1] == '3')
            {
                transformAtual.position = I[3].position;
            }
            else if (resultado[1] == '4')
            {
                transformAtual.position = I[4].position;
            }
            else if (resultado[1] == '5')
            {
                transformAtual.position = I[5].position;
            }
            else if (resultado[1] == '6')
            {
                transformAtual.position = I[6].position;
            }
            else if (resultado[1] == '7')
            {
                transformAtual.position = I[7].position;
            }
            else if (resultado[1] == '8')
            {
                transformAtual.position = I[8].position;
            }
            else if (resultado[1] == '9')
            {
                transformAtual.position = I[9].position;
            }
        }
        else if (resultado[0] == 'J' || resultado[0] == 'j')
        {
            if (resultado[1] == '0')
            {
                transformAtual.position = J[0].position;
            }
            else if (resultado[1] == '1')
            {
                transformAtual.position = J[1].position;
            }
            else if (resultado[1] == '2')
            {
                transformAtual.position = J[2].position;
            }
            else if (resultado[1] == '3')
            {
                transformAtual.position = J[3].position;
            }
            else if (resultado[1] == '4')
            {
                transformAtual.position = J[4].position;
            }
            else if (resultado[1] == '5')
            {
                transformAtual.position = J[5].position;
            }
            else if (resultado[1] == '6')
            {
                transformAtual.position = J[6].position;
            }
            else if (resultado[1] == '7')
            {
                transformAtual.position = J[7].position;
            }
            else if (resultado[1] == '8')
            {
                transformAtual.position = J[8].position;
            }
            else if (resultado[1] == '9')
            {
                transformAtual.position = J[9].position;
            }
        }
      
    }
    void OnGUI()
    {
        Cronometro += Time.deltaTime;
     //   Debug.Log(Cronometro);
        if (Cronometro > 1.5)
        {
            ler();
            Cronometro = 0;
            ler();
        }
     

    }
    public void ler()
    {
        try
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(camTexture.GetPixels32(),
              camTexture.width, camTexture.height);
            if (result != null)
            {
                Debug.Log("PARTE 1 = " + result.Text[0] + " PARTE 2 = " + result.Text[1]);
                pessoaAgent.enabled = false;
                CompararResultado(result.Text);
                pessoaAgent.enabled = true;
            }
        }
        catch (Exception ex) { Debug.LogWarning(ex.Message); }
    }


}
