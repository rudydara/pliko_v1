using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfiguracionesScript : MonoBehaviour
{
    //variables slider volumen
    public Slider slider;
    public float sliderValue;

    // Start is called before the first frame update
    void Start()
    {
        //slider volumen
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = slider.value;
    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = slider.value;
    }

}
