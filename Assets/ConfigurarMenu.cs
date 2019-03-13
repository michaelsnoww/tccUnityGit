using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigurarMenu : MonoBehaviour
{
    public GameObject travarTela;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toogle_trabar(bool newValue)
    {
        travarTela.SetActive(newValue);
    }
}
