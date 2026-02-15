// Ponle Rigid Body con Is Kinematic y sin Is Trigger para que colisione con cosas pero active triggers al tocarlos
// Puedes ajustar su velocidad de giro
// No te olvides de asignar alrededor de que objeto gira
using UnityEngine;

public class MovimientoEsfera : MonoBehaviour
{
    [Header("Configuración de la órbita")]
    public Transform centro;               // Punto alrededor del que girará
    public float gradosPorSegundo = 90f;   // Velocidad de giro

    private float radio;                   // Distancia inicial al centro

    void Start()
    {
        if (centro == null)
        {
            // Si no asignaste centro, usa Vector3.zero
            centro = new GameObject("CentroTemporal").transform;
            centro.position = Vector3.zero;
        }

        // Guardar el radio inicial desde la posición actual
        radio = Vector3.Distance(transform.position, centro.position);
    }

    void Update()
    {
        // Calcular dirección desde el centro
        Vector3 direccion = (transform.position - centro.position).normalized;

        // Mantener distancia constante
        transform.position = centro.position + direccion * radio;

        // Rotar alrededor del centro
        transform.RotateAround(centro.position, Vector3.up, gradosPorSegundo * Time.deltaTime);
    }
}
