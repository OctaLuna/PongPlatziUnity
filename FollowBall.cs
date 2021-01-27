using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    //VARIABLES//
    
    //Esta variables es para tener el transform de la pelotita
    public Transform Ball;
    //Esta es la velocidad del enemigo
    public float Speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //este if es para ver si el juego inicio, si el juego no inicio no pasara nada
        //Ball estamos haciendo la referencia a una variable creada anteriormente
        //GetComponent<BallBehaviour>() en esta parte estamos llamando a un objeto o script que es el Ballehaviour
        //gameStarted esta es la variable a la cual nos queremos referenciar
        if(Ball.GetComponent<BallBehaviour>().gameStarted){
            //esto va a pasar cuando la posicion de la Ball sea mayor a la del enemigo
            //transform.position.y es la posicion del enemigo
            //Ball.position.y es la posicion de la pelotita
            if(transform.position.y < Ball.position.y){
                //Estamos cambiando la posicion del enemigo para que antes de iniciar el juego no siga a la pelotita
                //new Vector3 estamos creando un nuevo vector 3 para cambiar la posicion del enemigo
                //transform.position.x, transform.position.y + Speed, transform.position.z son las posiciones que vamos a cambiar
                transform.position = new Vector3(transform.position.x, transform.position.y + Speed, transform.position.z);
            }
            else if(transform.position.y > Ball.position.y){
                //Estamos cambiando la posicion del enemigo para que antes de iniciar el juego no siga a la pelotita
                //new Vector3 estamos creando un nuevo vector 3 para cambiar la posicion del enemigo
                //transform.position.x, transform.position.y + Speed, transform.position.z son las posiciones que vamos a cambiar
                transform.position = new Vector3(transform.position.x, transform.position.y - Speed, transform.position.z);
            }
        }     

        
    
    
    
    }
    
    
    
       
}
