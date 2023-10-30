using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosPlayer : MonoBehaviour
{
    public int puntosPlayerActual;
    [SerializeField] TMP_Text text_items;
    // Start is called before the first frame update
    void Start()
    {
        text_items.text = "X " + 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Puntos(int puntosRecividos ) {
        puntosPlayerActual += puntosRecividos;
        text_items.text = "X " + puntosPlayerActual;
        print("Hit! itmes");
    }
}
