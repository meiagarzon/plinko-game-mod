using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOriginalScene : MonoBehaviour
{
    public void LoadOriginal()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
