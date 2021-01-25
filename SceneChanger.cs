using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //Esto es para poder controlar las escenas


public class SceneChanger : MonoBehaviour
{
    //Esto es para poder manejar las escenas la variable tiene que ser el nombre de la escena a la cual tiene que cambiar
    public void ChangeSceneTo(string sceneName){
        //Esto es para cambiar de escenas
        SceneManager.LoadScene(sceneName);
    }

}
