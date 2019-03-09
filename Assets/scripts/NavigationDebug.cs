using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(LineRenderer))]
public class NavigationDebug : MonoBehaviour {
    [SerializeField]
    private NavMeshAgent agentToDebug;
    private LineRenderer linerenderer;

	// Use this for initialization
	void Start () {
        linerenderer = GetComponent<LineRenderer>();	
	}
	
	// Update is called once per frame
	void Update () {
        if (agentToDebug.hasPath)
        {
            linerenderer.positionCount = agentToDebug.path.corners.Length;
            linerenderer.material.color=Color.black;
          //  linerenderer.SetWidth(5f, 5f);
            linerenderer.startWidth=5f;
            linerenderer.endWidth=5f;
            linerenderer.SetPositions(agentToDebug.path.corners);
     
            linerenderer.enabled = true;
        }
        else
        {
            linerenderer.enabled = false;
        }
	}
}
