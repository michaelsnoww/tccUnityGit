using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class scriptMovimento : MonoBehaviour {
    public NavMeshAgent agenteNav;
    public Transform alvo;
                    
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
	}
}
