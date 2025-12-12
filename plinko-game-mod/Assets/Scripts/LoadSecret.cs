using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSecret : MonoBehaviour
{
    public void LoadSecretScene()
    {
        SceneManager.LoadSceneAsync(1);
    }
}
