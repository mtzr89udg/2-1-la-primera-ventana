using UnityEngine;
using UnityEngine.UI;

public class ChangeFont : MonoBehaviour
{
    public Text uiText; // Asigna el componente de texto desde el Inspector
    public Font newFont; // Asigna la nueva fuente desde el Inspector

    public void ChangeTextFont()
    {
        if (uiText != null && newFont != null)
        {
            uiText.font = newFont;
        }
    }
}
