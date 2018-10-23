using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTouch : MonoBehaviour {

    public float xMin;
    public float zMin;
    public float xMax;
    public float zMax;



    // Update is called once per frame
    void Update () {
        if (Input.touchCount > 0)
        {
            transform.Translate(Input.GetTouch(0).deltaPosition * Time.deltaTime * 1f);
            Camera.main.transform.position = new Vector3(Mathf.Clamp(Camera.main.transform.position.x, xMin, xMax), 40, Mathf.Clamp(Camera.main.transform.position.z, zMin, zMax));

        }
    }
}
