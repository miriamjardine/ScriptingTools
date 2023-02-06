using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class LoadSceneSO : ScriptableObject
{
    
    public void LoadScene(String sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
