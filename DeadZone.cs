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
    //Lo que estamos haciendo es llamar a otro script desde una variable tenerla como referencia, en este caso es el script SceneChanger
    public SceneChanger sceneChanger;
    //cuando te anotan un anotacion suene una cancion
    public AudioSource AudioAnotacion;



    //Esta funcion es casi lo mismo que la funcionOnCollisionEnter2D(), pero en esta en vez de colicionar es cuando la traspasa, es Trigger
    private void OnTriggerEnter2D(Collider2D ball) {
        Debug.Log("Trigger ufffffffff");
        
        AudioAnotacion.Play();
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

        //Lo que estamos haciendo es que cuando alguien anote el ball la pelotita regrese al player
        //ball es la variable de la funcion OntriggerEnter2D
        //GetComponent esta funcion nos sirve para conseguir algo de un objeto o script
        //BallBehaviour este es el script al cual estamos accediendo
        //gameStarted = false; esta es la variable que tenemos que cambiar para que la pelotita regrese al player
        ball.GetComponent<BallBehaviour>().gameStarted = false;

        //Estamos llamando a la funcion checkedScore
        checkedScore();
    }

    //Esto es para poder que la variable que cuenta cuantas anotaciones metieron tenga el mismo valor que la que representa el Text del UI
    void UpdateScoreLabel(Text label, int score){
        //lo que estamos haciendo es copiar el mismo valor del score a label para que tengan el mismo valor
        //label.text estamos accediendo al text del label que seria el texto que se muestra en pantalla del juego el UI
        //score.ToString() estamos haciendo que la variable score sea la misma que la variable label en terminos de valor
        //ToString() es para volver string la variable de score que es entero
        label.text = score.ToString();
    }

    //Esto es para medir el contador de las anotaciones
    void checkedScore(){
        //Esto es una restriccion de anotaciones que en este caso son 3, es para ver quien gano el player o enemy en las anotacions
        
        //Esto es para poner restricciones cuantas anotaciones le metio el player al enemy
        if(scorePlayerQuantity >= 3){
            //lo que estamos haciendo es llamar a la variable que hace referencia a el script SceneChanger, y estamos llamando a la funcion ChangeSceneTo
            sceneChanger.ChangeSceneTo("WinScene");
        }
        //Esto es para poner restricciones cuantas anotaciones le metio el enemy al player
        else if(scoreEnemyQuantity >= 3){
            //lo que estamos haciendo es llamar a la variable que hace referencia a el script SceneChanger, y estamos llamando a la funcion ChangeSceneTo
            sceneChanger.ChangeSceneTo("LoserScene");
        }
    }

    
}





    //Esta es una nueva funcion que se activa cuando otro gameObject choca con este gameObject 
    //private void OnCollisionEnter2D(Collision2D collision) {
    //   Debug.Log("Collision bummmmm!!");
    //}