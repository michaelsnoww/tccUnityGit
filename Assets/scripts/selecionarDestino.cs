using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class selecionarDestino : MonoBehaviour {
    public GameObject player;
    scriptMovimento scripMover;
    public  Transform esseAlvo;
  

    void Start () {
        scripMover = player.GetComponent<scriptMovimento>();
        esseAlvo = this.gameObject.transform.GetChild(0);
    }
	
    public void MouseUp()
    {

            scripMover.alvo = esseAlvo;

    }

}
