using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    //VARIABLES//
    
    //esta variable es para hacer una referencia a el GameObject Paddle, especificamente a su transform
    public Transform paddle;

    //esta variable es para que el booleano vea si nuestro juego ya a iniciado
    public bool gameStarted = false;

    //Esto es para poder acceder al componente que se añadio, que es el Rigidbody2D, del personaje y tenerlo en un sola variable
    public Rigidbody2D rbBall;
    ///Estas variables son para medir la velocidad de la pelota en "x" y "y"
    public float speedBallX = 30;
    public float speedBallY = 30;

    //esta es para que cuando el ball esta en el transform del player, no se quede totalmente en sus ejes, que tenga un espacio
    float posDif;

    // Start is called before the first frame update
    void Start()
    {
        //esta es para que cuando el ball esta en el transform del player, no se quede totalmente en sus ejes, que tenga un espacio
        //paddle.position.x en esta parte estamos accediendo al position en eje x del pall que es el player
        //transform.position.x es la posicion del ball en eje x
        //lo estamos restando para que el ball no este en el mismo eje en x del player 
        posDif = paddle.position.x - transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStarted == false){
            //Esto va a pasar su nuestro juego no a iniciado     



            //esto es para acceder al transform.position de la Ball y cambiarlo por el del player, pero que tenga un espacio
            //transform.position en esta parte estamos accediendo al transform de el ball
            //new Vector3 estamos creando un nuevo Vector 3
            //paddle.position.x - posDif lo que estamo haciendo es restar la posicion del paddle el eje x, con la variable posDif, esto es para que el ball tengo un espacio y no este pegado al player
            //paddle.position.y estamos cambiando la posicion del eje y, del ball por la de el player
            //paddle.position.z estamos cambiando la posicion del eje z, del ball por la de el player
            transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);    
        
            //esto es para que cuando apretamosel clik izquierdo del mouse se cambie gameStarted a true, lo que significa es que el juego ya a iniciado
            //Input.GetMouseButtonDown(0) es una variable que tiene preinstalada unity 
            //GetMouseButtonDown es cuando apretamos una tecla del mouse 
            //(0) es el clik izquierdo del mouse
            if(Input.GetMouseButtonDown(0)){
                //esto es para la velocidad de nuestra pelota, que en este caso es "15 en x" y "15 en y", solo estamos usando 2 vectores por que solo nos intereza los valores en "x" y "y"
                rbBall.velocity = new Vector2(speedBallX, speedBallY);
                //Esta variable indica que se inicio el juego
                gameStarted = true;    
                

                    
            }
        }

    }
}
