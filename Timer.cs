using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{ 
    // Definimos las variables de los minutos y los segundos.
    // Los segundos son "float" ya que haremos que dependa de Time.deltaTime ~ 0.01 segundos
    private int minutes;
    private float seconds;
    public TextMeshProUGUI minutesText;
    public TextMeshProUGUI secondsText;
    private int secondsAprox;

    private void Start()
    {
        // Inicializar los valores del tiempo, si es necesario
        minutes = 2; // Ejemplo: 1 minutos
        seconds = 0.0f;
    }

    // Creamos un metodo que hace de contador 
    private void UpdateTime()
    {
        // Actualizar los segundos utilizando Time.deltaTime
        seconds -= Time.deltaTime;

        // Verificar si los segundos han llegado a cero
        if (seconds <= 0)
        {

            // Verificar si hay minutos restantes
            if (minutes > 0)
            {
                // Reiniciar los segundos a 59 y restar un minuto
                seconds += 59.0f;
                minutes--;
            }
            else
            {
                // No hay minutos restantes, reiniciar nivel (c�digo de reinicio de escena)
                // Copiamos el codigo que hicimos hace unas clases para resetear el nivel
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    private void Update()
    {
        // Actualizar el valor del tiempo cada frame
        UpdateTime();
        minutesText.text = minutes.ToString();
        


        // Printeamos por la consola el tiempo restante
        secondsAprox = Mathf.RoundToInt(seconds);
        secondsText.text = secondsAprox.ToString();
    }
}
