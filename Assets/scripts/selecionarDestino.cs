using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selecionarDestino : MonoBehaviour {
    public GameObject player;
    scriptMovimento scripMover;
    public Transform esseAlvo;
    public float clickTimer = 1f;
    private int counter=0;

    // Use this for initialization
    void Start () {
        scripMover = player.GetComponent<scriptMovimento>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        buttonListner();

    }

    private void buttonListner()
    {
        counter++;
            if (counter == 1)
        {
            StartCoroutine("doubleClickEvent");
        }
    }

    IEnumerator doubleClickEvent()
    {
        yield return new WaitForSeconds(clickTimer);
        if (counter > 1)
        {
            scripMover.alvo = esseAlvo;
        }

        yield return new WaitForSeconds(.01f);
        counter = 0;
    }

}
