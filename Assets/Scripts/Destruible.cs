// Esto ponselo a cualquier cosa y podra destruirse con un rayo del CursorDisparador
// Hay para ponerle particulas si quieres
// Recuerda ponerl el Tag Destruible al objeto que le pongas esto
using JetBrains.Annotations;
using UnityEngine;

public class Destruible : MonoBehaviour
{
    //public ParticleSystem particulas;
    public void Destruir()
    {
        Debug.Log("Objeto peta");

        // particulas.Play();

        Destroy(gameObject);

    }
}
    