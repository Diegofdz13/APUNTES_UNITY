// Este código hace que al objeto que se lo pongas se destruya si toca el collider de otro
// Acuerdate activar en Is Trigger en el objeto que esta puestos
using UnityEngine;

public class ObjetoSeDestruye : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
