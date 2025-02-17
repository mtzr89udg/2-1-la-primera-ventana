using UnityEngine;

public class GameLoop : MonoBehaviour
{
    void Update()
    {
        // Lógica del juego que se ejecuta en cada frame
        HandlePlayerInput();
        UpdateGameState();
    }

    void HandlePlayerInput()
    {
        // Ejemplo: Movimiento del jugador
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
    }

    void UpdateGameState()
    {
        // Actualizar el estado del juego, como puntuación o condiciones de victoria
    }
}

