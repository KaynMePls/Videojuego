using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{

    [SerializeField] int puntosEnviados;
    AudioSource audioSource;

    private void Start()
    {
        audioSource= GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PuntosPlayer>().Puntos(puntosEnviados);
            audioSource.Play();          
            puntosEnviados = 0;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;             
            Destroy(gameObject, 0.3f);
            
        }
    }
    
}
