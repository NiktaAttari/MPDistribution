using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    [SerializeField] private string menuScene = "Menu";

    public void LoadScene()
    {
        SceneManager.LoadScene(menuScene);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            LoadScene();
        }
    }
}