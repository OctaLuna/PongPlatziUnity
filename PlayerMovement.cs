using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        //Esto es para que en la consola nos aparesca la posicion del mouse
        Debug.Log(Input.mousePosition);

        //Esta en Vector 3 para que podamos acceder a los 3 ejes "x", "y" y "z"
        //Esto es para que el player siga al mouse, es para el juego en celular y sigua nuestro dedo donde estemos 
        //Camera.main.ScreenToWorldPoint esto es porque el mouse se mueve en pixeles y el player no, esto es para poder transformarlo
        //Input.mousePosition esto es la posicion del mouse
        Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Esto es para que al mover el player con las cordenadas del mouse, pero no en z por que el player desapareceria 
        //transform.position esta es la posicion de el player
        //new Vector3 esto es para poder crear un nuevo vector 3, que tiene 3 cordenas("x", "y", "z")
        transform.position = new Vector3(MousePos.x, MousePos.y, transform.position.z);
    }
}
