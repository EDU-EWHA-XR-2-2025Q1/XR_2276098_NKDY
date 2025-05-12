using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class Scene_Controller : MonoBehaviour
{
    public void OnClick_LoadScene(Object SceneObject)
    {
        Debug.Log(SceneObject.name);
        VuforiaBehaviour.Instance.enabled = false;
        SceneManager.LoadScene(SceneObject.name);
    }
}