// Este codigo es para hacer colliders que detecte TAGS, en este caso el Jugador
// Recuerda poner TAG a lo que activa este Trigger
using UnityEngine;

public class Detector : MonoBehaviour
{
    // Permite asignar que Activas cuando se activa el trigger (en este caso un CANVAS)
    public GameObject etiqueta;
    private void OnTriggerEnter(Collider other)
    {
        // La desactivas al inciar
        etiqueta.SetActive(false);

        // Se activa al detectar determinado TAG
        if (other.CompareTag("Player"))
        {
            etiqueta.SetActive(true);
        }
    }
    // Lo desactiva cuando ese TAG sale del Collider
    private void OnTriggerExit(Collider other)
    {
        // Cuando algo sale del trigger
        if (other.CompareTag("Player"))
        {
            etiqueta.SetActive(false);
        }
    }
}
