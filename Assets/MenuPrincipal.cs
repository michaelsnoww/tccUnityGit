using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject mapa;
    public GameObject mapaBusca;
    public GameObject sobre;
    public GameObject essaTela;

    public RawImage rawImage;
    private WebCamTexture camTexture;
    public GameObject rawGameObject;

    public void AbrirMapa()
    {
        essaTela.SetActive(false);
        mapa.SetActive(true);
    }

    public void AbrirSobre()
    {
        essaTela.SetActive(false);
        sobre.SetActive(true);

    }

    public void AbrirBuscar()
    {
        essaTela.SetActive(false);
        mapaBusca.SetActive(true);
    }

    public void irParaHome()
    {
        mapa.SetActive(false);
        essaTela.SetActive(true);

    }
    public void irParaHomesobre()
    {
        sobre.SetActive(false);
        essaTela.SetActive(true);

    }


    

    void Start()
    {
       // rawImage = GetComponent<RawImage>();

        camTexture = new WebCamTexture();
        camTexture.requestedWidth = 320;
        camTexture.requestedHeight = 480;

        if (camTexture != null)
        {

            camTexture.Play();
            rawImage.texture = camTexture;
        }
        rawGameObject.SetActive(false);
    }
}
