
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanZoom : MonoBehaviour
{

    public GameObject setores;

    Vector3 touchStart;
    public float zoomOutMin = 100;
    public float zoomOutMax = 400;
    public float velocidadeZoom=3;
    public float velocidadeZoomTouch=5;
    public float xMin;
    public float zMin;
    public float xMax;
    public float zMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //verifica se existem toques na tela e caso seja verdadeiro aplica zoom ou move a tela, dependendo da quantidade de toques.
        if (Input.GetMouseButtonDown(0))
        {
            touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            zoom(difference * velocidadeZoomTouch);

        } else if (Input.GetMouseButton(0))
        {
            Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += direction;
        }
        zoom(Input.GetAxis("Mouse ScrollWheel")*velocidadeZoom);
        Camera.main.transform.position = new Vector3(Mathf.Clamp(Camera.main.transform.position.x, xMin, xMax), 40, Mathf.Clamp(Camera.main.transform.position.z, zMin, zMax));
        if(Camera.main.orthographicSize >= 600)
        {
            setores.active = true;
        }else if(Camera.main.orthographicSize < 600)
        {
            setores.active = false;

        }
    }

    void zoom(float increment)
    {
        //Aumento o zoom  não ultrapassando os limites fixados pelo Clamp referente a zoomOutMin e zoomOutMax
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }
}
