using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneBehaviour : MonoBehaviour
{
    public void LoadCarOne()
    {
        SceneManager.LoadScene("Cab1", LoadSceneMode.Single);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

}
