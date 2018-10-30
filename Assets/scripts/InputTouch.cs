using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTouch : MonoBehaviour {

    public float xMin;
    public float zMin;
    public float xMax;
    public float zMax;
    Transform transform;
    public GameObject canvasPainel;
    RawImage raw;


    private void Start()
    {
        raw = canvasPainel.GetComponent<RawImage>();
        transform = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update () {
          if (Input.touchCount > 0)
          {
              transform.Translate(Input.GetTouch(0).deltaPosition * Time.deltaTime * -1f);
              Camera.main.transform.position = new Vector3(Mathf.Clamp(Camera.main.transform.position.x, xMin, xMax), 40, Mathf.Clamp(Camera.main.transform.position.z, zMin, zMax));

          }
        Camera.main.transform.position = new Vector3(Mathf.Clamp(Camera.main.transform.position.x, xMin, xMax), 40, Mathf.Clamp(Camera.main.transform.position.z, zMin, zMax));

    }

    public void zoomIn()

    {
     //   raw.raycastTarget = false;
        if (Camera.main.orthographicSize <= 80)
        {
            Camera.main.orthographicSize += 5;

        }
        if (zMin < -330)
        {
            zMin += 3;
        }
        if (xMin < 190)
        {
            xMin += 2;
        }

       // raw.raycastTarget = true;

    }
    public void zoomOut()
    {
        if (Camera.main.orthographicSize >= 40)
        {
            Camera.main.orthographicSize -= 5;

            if (zMin >= -360)
            {
                zMin -= 3;
            }
            if(xMin >= 170)
            {
                xMin -= 2;
            }
           

        }



    }

    public void up()
    {
        Vector3 camera = Camera.main.transform.position;
        camera.z += 2f;
        Camera.main.transform.position = camera;


    }
    public void down()
    {
        Vector3 camera = Camera.main.transform.position;
        camera.z -= 2f;
        Camera.main.transform.position = camera;


    }
    public void left()
    {
        Vector3 camera = Camera.main.transform.position;
        camera.x -= 2f;
        Camera.main.transform.position = camera;


    }    public void right()
    {
        Vector3 camera = Camera.main.transform.position;
        camera.x += 2f;
        Camera.main.transform.position = camera;


    }

}
