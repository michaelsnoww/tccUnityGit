using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class LoginController : MonoBehaviour {
    private const string Login = "michael";
    private const string Pass = "123456";
    [SerializeField]
    private InputField usuarioField = null;
    [SerializeField]
    private InputField senhaField = null;
    [SerializeField]
    private Text fedBackmsg = null;
    [SerializeField]
    private Toggle remeberData = null;

    void Start () {
        if(PlayerPrefs.HasKey("remember")&& PlayerPrefs.GetInt("remember") == 1){
            usuarioField.text = PlayerPrefs.GetString("rembenderLogin");
            senhaField.text = PlayerPrefs.GetString("rembenderPass");

        }
		
	}
	
	public void FazerLogin () {
        string usuario = usuarioField.text;
        string senha = senhaField.text;
        if (remeberData.isOn)
        {
            PlayerPrefs.SetInt("remember", 1);
            PlayerPrefs.SetString("rembenderLogin", usuario);
            PlayerPrefs.SetString("rembenderPass", senha);

        }
        if(usuario==Login && senha == Pass)
        {
            fedBackmsg.CrossFadeAlpha (100f, 0, false);
            fedBackmsg.color = Color.green;
            fedBackmsg.text = "Login Realizado com sucesso \n carregando Mapa...";
            StartCoroutine(CarregaCena());
        }
        else
        {
            fedBackmsg.CrossFadeAlpha(100f, 0, false);
            fedBackmsg.color = Color.red;
            fedBackmsg.text = "Usuário ou senha inválidos \n Tente Novamente...";
            fedBackmsg.CrossFadeAlpha(0f, 2f, false);
            usuarioField.text = "";
            senhaField.text = "";



        }


    }
    IEnumerator CarregaCena()
    {
        yield return new WaitForSeconds(5);
        Application.LoadLevel("MapaIFRR");
    }
}
