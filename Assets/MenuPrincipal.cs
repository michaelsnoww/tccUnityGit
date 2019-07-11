using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject mapa;
    public GameObject mapaBusca;
    public GameObject sobre;
    public GameObject essaTela;

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
}
