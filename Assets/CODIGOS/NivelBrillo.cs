using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelBrillo : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image panelBrillo;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Brillo", 0.5f);

        // Establece el componente alfa (transparencia) en función del valor del Slider.
        Color panelColor = panelBrillo.color;
        panelColor.a = slider.value;
        panelBrillo.color = panelColor;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("Brillo", sliderValue);

        // Actualiza el componente alfa (transparencia) en función del valor del Slider.
        Color panelColor = panelBrillo.color;
        panelColor.a = slider.value;
        panelBrillo.color = panelColor;
    }
}
