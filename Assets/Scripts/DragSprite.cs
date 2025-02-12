using UnityEngine;

public class DragSprite : MonoBehaviour
{
    private bool isDragging = false;

    void OnMouseDown()
    {
        isDragging = true;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Asegúrate de que el Sprite permanezca en el plano 2D
            transform.position = mousePosition;
        }
    }
}
