using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrampaQuitaVida : MonoBehaviour
{

    [SerializeField] int dano=1;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<VidaPlayer>().RestarVida(dano);
            print("Trigger");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<VidaPlayer>().RestarVida(dano);
            print("Collider");
        }
    }
}
