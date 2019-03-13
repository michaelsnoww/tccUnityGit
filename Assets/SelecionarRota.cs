using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecionarRota : MonoBehaviour
{
    private GameObject Alvo;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                if (hit.collider.tag == "Chao")
                {
                 //   Debug.Log(hit.collider.name);
                    Alvo = hit.collider.gameObject;
                    
                }
                
            }
        }
    }
    private void OnGUI()
    {
        Event mouse = Event.current;
        if (mouse.clickCount == 2)
        {
            Alvo.transform.SendMessage("MouseUp");
            
        }
    }

}
