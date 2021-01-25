using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;      //Esta es un libreria para manegar el cambio de escenas
using UnityEngine.UI;                   //Esto es para poder manejar el UI de un juego, esto sirve para poner la vida del jugador, el puntaje, etc.

public class DeadZone : MonoBehaviour
{
    //VARIABLES//

    //Este es una variable de la libreria de UI, es para mostrar los goles que le marcaron al player;
    public Text scorePlayerText;

    //Este es una variable de la libreria de UI, es para mostrar los goles que le marcaron al enemigo;
    public Text scoreEnemyText;

    //Esta variable es para contrar las anotaciones que les hicieron al player
    private int scorePlayerQuantity;
    //Esta variable es para contrar las anotaciones que les hicieron al enemigo
    private int scoreEnemyQuantity;
    



    //Esta funcion es casi lo mismo que la funcionOnCollisionEnter2D(), pero en esta en vez de colicionar es cuando la traspasa, es Trigger
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Trigger ufffffffff");
        

        //esto es para hacer el conteo de las anotaciones que le metieron al player
        //gameObject.tag estamos referenciando a el Tag "Left" que es el Tag que usa el arco de el player
        if(gameObject.tag == "Left"){
            //En esta parte se esta sumando 1 a la variable que cuenta las anotaciones del enemigo
            scoreEnemyQuantity++;
            //estamos llamando a la funcion UpdateScoreLabel con sus respectivas condicionales
            UpdateScoreLabel(scoreEnemyText, scoreEnemyQuantity);
        }
        //esto es para hacer el conteo de las anotaciones que le metieron al player
        //gameObject.tag estamos referenciando a el Tag "Left" que es el Tag que usa el arco de el player
        else if(gameObject.tag == "Right"){
            //En esta parte se esta sumando 1 a la variable que cuenta las anotaciones del player
            scorePlayerQuantity++;
            //estamos llamando a la funcion UpdateScoreLabel con sus respectivas condicionales
            UpdateScoreLabel(scorePlayerText, scorePlayerQuantity);
        }
    }

    //Esto es para poder que la variable que cuenta cuantas anotaciones metieron tenga el mismo valor que la que representa el Text del UI
    void UpdateScoreLabel(Text label, int score){
        //lo que estamos haciendo es copiar el mismo valor del score a label para que tengan el mismo valor
        //label.text estamos accediendo al text del label que seria el texto que se muestra en pantalla del juego el UI
        //score.ToString() estamos haciendo que la variable score sea la misma que la variable label en terminos de valor
        //ToString() es para volver string la variable de score que es entero
        label.text = score.ToString();
    }

    
}





    //Esta es una nueva funcion que se activa cuando otro gameObject choca con este gameObject 
    //private void OnCollisionEnter2D(Collision2D collision) {
    //   Debug.Log("Collision bummmmm!!");
    //}