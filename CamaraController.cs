using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    // Start is called before the first frame update
    
    //Referencia a nuestro jugador

    public GameObject jugador;
    //Para registrar la diferencia entre la posicion de la camara y la del jugador
    private Vector3 offset;
    void Start()
    {
        //diferencia entre la posicion de la camara y la del jugador
        offset = transform.position - jugador.transform.position;
    }

    void LateUpdate () {
        //Actualizo la posición de la cámara
        transform.position = jugador.transform.position + offset;
    }
    
}
