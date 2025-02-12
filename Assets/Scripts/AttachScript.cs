using UnityEngine;

public class AttachScript : MonoBehaviour
{
    public GameObject targetObject; // Asigna el objeto al que deseas fijar el script

    public void AttachNewScript()
    {
        if (targetObject != null)
        {
            targetObject.AddComponent<DragSprite>(); // Cambia "DragSprite" por el nombre del script que deseas fijar
        }
    }
}
