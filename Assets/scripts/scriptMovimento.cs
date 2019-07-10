using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class scriptMovimento : MonoBehaviour {
    public NavMeshAgent agenteNav;
    public Transform alvo;
    public float distanciaRest;
    public Text texto;
	// Use this for initialization
	void Start () {
        if (agenteNav == null)
        {
            agenteNav = this.gameObject.GetComponent<NavMeshAgent>();
        }
	}
	
	// Update is called once per frame
	void Update () {
        agenteNav.SetDestination(alvo.position);
        distanciaRest = agenteNav.remainingDistance;
        texto.text="Distancia Restante: " + distanciaRest; 

    }
}
