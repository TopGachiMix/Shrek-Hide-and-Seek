using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneManagers : MonoBehaviour
{



    public void RestartScenes()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SceneChange(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
    }
}
