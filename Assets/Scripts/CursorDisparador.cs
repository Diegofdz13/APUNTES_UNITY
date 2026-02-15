// Para disparar
// Asigna a la camara que lo usa, es mejor
// Muy importante que la camara asignada tenga el TAG maincamera
// Para destruir cosas funciona con el codigo DESTRUIBLE
// Si quieres que solo active cosas toca el tema de la etiqueta en la 38
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CursorDisparador : MonoBehaviour
{
    // Para asignar la cámara
    [SerializeField] Camera laCamaraQueQuieroUtilizar;

    // Se guarda la cámara principal
    Camera mainCamera;

    private void Start()
    {
        // Guarda en mainCamera la cámara MainCamera del proyecto
        mainCamera = Camera.main;
    }

    RaycastHit hit;
    void Update()
    {
        // Comprueba si el botón izquierdo está siendo presionado
        if (Mouse.current.leftButton.isPressed)
        {
            // Crea un rayo que sale desde mainCamera y apunta a la posición del ratón
            Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
            // Comprueba si el rayo impacta
            if (Physics.Raycast(ray, out hit, 20f))
            {
                // Comprueba si el objeto golpeado tiene la etiqueta Destruible
                if (hit.collider.CompareTag("Destruible"))
                {
                    // Busca el script Destruible en el objeto golpeado
                    // Llama al método Destruir()
                    hit.collider.GetComponent<Destruible>().Destruir();
                }
            }
            Debug.Log(Mouse.current.position.ReadValue());
            // Muestra el rayo en la escena (no en el juego)
            Debug.DrawRay(ray.origin, ray.direction * 20f, Color.red, 0.1f);
        }
    }
}
