using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selecionarDestino : MonoBehaviour {
    public GameObject player;
    scriptMovimento scripMover;
    public Transform esseAlvo;
    // Use this for initialization
	void Start () {
        scripMover = player.GetComponent<scriptMovimento>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        scripMover.alvo = esseAlvo;

    }

}
