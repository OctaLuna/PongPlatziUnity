using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    //Esta es una nueva funcion que se activa cuando otro gameObject choca con este gameObject 
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Collision bummmmm!!");
    }

    //Esta funcion es casi lo mismo que la funcionOnCollisionEnter2D(), pero en esta en vez de colicionar es cuando la traspasa, es Trigger
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Trigger ufffffffff");
    }
}
