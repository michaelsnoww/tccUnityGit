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
    public GameObject mapa;
    public GameObject MenuBusca;
    // Start is called before the first frame update
    void Start()
    {
      //  m_Dropdown = GetComponent<Dropdown>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Banheiro()
    {
        GetLocais("Banheiro");
    }
    public void Salas()
    {
        GetLocais("Salas");
    }


    public List<Locais> GetLocais(string tipo)
    {
        if (tipo.Equals("Banheiro"))
        {
            opcao = tipo;
            locaisBusca = gerenciarLocais.banheiros;
            PopularDropdowm(m_Dropdown, locaisBusca);

        }
        if (tipo.Equals("Salas"))
        {
            opcao = tipo;
            locaisBusca = gerenciarLocais.salas;
            PopularDropdowm(m_Dropdown, locaisBusca);
        }
     /*   foreach (Locais locais in locaisBusca) {

            Debug.LogError(locais.name);
        }*/
        return null;
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
            if (opcao.Equals("Salas"))
            {
                alvo = gerenciarLocais.salas[m_Dropdown.value].gameObject;
                destino = alvo.gameObject.transform.GetChild(0);
                scriptMovimento.alvo = destino;
                // destino = alvo.GetComponent<selecionarDestino>();
                //   scriptMovimento.alvo = destino.esseAlvo;

            }


            mudarCamera();
        }

    }

    public void mudarCamera()
        {
        MenuBusca.SetActive(false);
        mapa.SetActive(true);
        }

    
}
