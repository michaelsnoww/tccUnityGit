using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTouch : MonoBehaviour {



	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            transform.Translate(Input.GetTouch(0).deltaPosition * Time.deltaTime * 1f);
        }
	}
}
