using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonNavegacion : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
    	SceneManager.LoadScene(sceneName);
    }
}
