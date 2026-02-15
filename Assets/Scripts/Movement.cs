// Se mueve, si señor
// Recuerda asignar la camara del jugador
// Puedes ajustar la velocidad de movimiento
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Referencia al componente CharacterController
    private CharacterController controller;
    // Velocidad de movimiento del jugador
    public float speed = 0.5f;
    // Referencia a la cámara para moverl el personbje hacia donde mira
    public Transform camara;

    void Start()
    {
        // Obtiene el CharacterController que está en el jugador
        controller = GetComponent<CharacterController>();

    }


    void Update()
    {
        // Detecta las teclas de movimiento
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Obtiene la dirección hacia donde mira la cámara
        Vector3 forward = camara.forward;
        // Evita que el movimiento se icline hacia arriba o abajo
        forward.y = 0f;
        // Evita aceleración extra
        forward.Normalize();

        // Obtiene la dirección lateral de la cámara
        Vector3 right = camara.right;
        // Evita que el movimiento se icline hacia arriba o abajo
        right.y = 0f;
        right.Normalize();

        // Calcula el movimiento combinando degún las teclas que se presionen
        Vector3 move = forward * v + right * h;

        // Mueve el jugador utilizando CharacterController 
        controller.Move(move * speed * Time.deltaTime);



    }
}
