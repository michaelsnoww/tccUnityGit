using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlle1 : MonoBehaviour {
    public  float speed = 25;
    private Camera camera;

	// Use this for initialization
	void Start () {
        camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
    {           
  /*/           if (Input.GetAxis("Mouse X") > 0 )
            {
                transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);

            }
            else if (Input.GetAxis("Mouse X") < 0 )
            {
                transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
            }*/

           //  && Input.GetButtonDown("Fire1")
    }
    public void zoomIn()
    {
        camera.orthographicSize+=5;   
         
    }
    public void zoomOut()
    {
        camera.orthographicSize -= 5;
    }


}
