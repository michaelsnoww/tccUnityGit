using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuEscolhe : MonoBehaviour
{
    public GerenciarLocais gerenciarLocais;
    Locais[] locaisBusca;
    public Dropdown m_Dropdown;
    public GameObject alvo;
    // public selecionarDestino destino;
    public Transform destino;
    public string opcao;
    public scriptMovimento scriptMovimento;

    //telas
    public GameObject listarSetores;
    public GameObject mapa;
    public GameObject MenuBusca;
    public GameObject telaPrincipal;
    // Start is called before the first frame update

    public void Banheiro()
    {
        GetLocais("Banheiro");
    }

    public void Salas()
    {
        GetLocais("Salas");
    }

    public void Entradas()
    {
        GetLocais("Entradas");
    }

    public void Laboratorios()
    {
        GetLocais("Laboratorios");
    }

    public void Outros()
    {
        GetLocais("Outros");
    }

    public void Coodernacao()
    {
        GetLocais("Coodernacao");
    }


    public void GetLocais(string tipo)
    {
        if (tipo.Equals("Banheiro"))
        {
            opcao = tipo;
            locaisBusca = gerenciarLocais.banheiros;
            PopularDropdowm(m_Dropdown, locaisBusca);
            IrParaSelecao();

        }
        else if (tipo.Equals("Salas"))
        {
            opcao = tipo;
            locaisBusca = gerenciarLocais.salas;
            PopularDropdowm(m_Dropdown, locaisBusca);
            IrParaSelecao();

        }
        else if (tipo.Equals("Entradas"))
        {
            opcao = tipo;
            locaisBusca = gerenciarLocais.entradas;
            PopularDropdowm(m_Dropdown, locaisBusca);
            IrParaSelecao();

        }
        else if (tipo.Equals("Laboratorios"))
        {
            opcao = tipo;
            locaisBusca = gerenciarLocais.laboratorios;
            PopularDropdowm(m_Dropdown, locaisBusca);
            IrParaSelecao();

        }
        else if (tipo.Equals("Outros"))
        {
            opcao = tipo;
            locaisBusca = gerenciarLocais.outros;
            PopularDropdowm(m_Dropdown, locaisBusca);
            IrParaSelecao();

        }
        else if (tipo.Equals("Coodernacao"))
        {
            opcao = tipo;
            locaisBusca = gerenciarLocais.coodernacao;
            PopularDropdowm(m_Dropdown, locaisBusca);
            IrParaSelecao();

        }

    }

    void PopularDropdowm(Dropdown dropdown, Locais[] array)
    {
        List<string> options = new List<string>();
        foreach(var option in array)
        {
            options.Add(option.name);
            
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
      //  busca(dropdown.value);
    }
    public void busca(/*int id*/)
    {
   
        if (opcao != null)
        {
            if (opcao.Equals("Banheiro"))
            {
                alvo = gerenciarLocais.banheiros[m_Dropdown.value].gameObject;
                destino = alvo.gameObject.transform.GetChild(0);
                scriptMovimento.alvo = destino;
  

            }
            else if (opcao.Equals("Salas"))
            {
                alvo = gerenciarLocais.salas[m_Dropdown.value].gameObject;
                destino = alvo.gameObject.transform.GetChild(0);
                scriptMovimento.alvo = destino;


            }
            else if (opcao.Equals("Entradas"))
            {
                alvo = gerenciarLocais.entradas[m_Dropdown.value].gameObject;
                destino = alvo.gameObject.transform.GetChild(0);
                scriptMovimento.alvo = destino;


            }
            else if (opcao.Equals("Laboratorios"))
            {
                alvo = gerenciarLocais.laboratorios[m_Dropdown.value].gameObject;
                destino = alvo.gameObject.transform.GetChild(0);
                scriptMovimento.alvo = destino;


            }
            else if (opcao.Equals("Outros"))
            {
                alvo = gerenciarLocais.outros[m_Dropdown.value].gameObject;
                destino = alvo.gameObject.transform.GetChild(0);
                scriptMovimento.alvo = destino;


            }
            else if (opcao.Equals("Coodernacao"))
            {
                alvo = gerenciarLocais.coodernacao[m_Dropdown.value].gameObject;
                destino = alvo.gameObject.transform.GetChild(0);
                scriptMovimento.alvo = destino;

            }


            AbrirMapa();
        }

    }

    public void AbrirMapa()
        {
        listarSetores.SetActive(false);
        mapa.SetActive(true);
        }

    public void IrParaSelecao()
    {
        MenuBusca.SetActive(false);
        listarSetores.SetActive(true);

    }
    public void VoltarMenuBusca()
    {
        listarSetores.SetActive(false);
        MenuBusca.SetActive(true);


    }
    public void VoltarHome()
    {
        MenuBusca.SetActive(false);
        telaPrincipal.SetActive(true);

    }

}
