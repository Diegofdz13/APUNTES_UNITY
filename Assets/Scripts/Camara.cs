// Recuerda asignar el Jugador en el que va asigada
// Obviamente puede ir asignada en cualquier camara y le dará movimiento
// Se puede ajustar la velocidad de manejo
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    // Velocidad de la cámara
    public float velocidad = 2f;
    // Referencia para rotar al jugador junto con la cámara
    public Transform Jugador;
    // Variable que guarda la rotación vertical de la cámara
    float RotacionX = 0f;
    void Start()
    {
        // Bloquea y centra el cursor
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        // Detecta el movimiento del ratón en horizontal y vertical
        float mouseX = Input.GetAxis("Mouse X") * velocidad * 7f * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * velocidad * 7f * Time.deltaTime;

        // Calcula la rotación vertical y la limita para que no gire demasiado
        RotacionX -= mouseY;
        RotacionX = Mathf.Clamp(RotacionX, -90f, 90f);

        // Aplica la rotación vertical a la cámara
        transform.localRotation = Quaternion.Euler(RotacionX, 0f, 0f);

        // Rota al jugador en horizontal
        Jugador.Rotate(Vector3.up * mouseX);

    }
}
