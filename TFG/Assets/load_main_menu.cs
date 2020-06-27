using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class load_main_menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("main_menu");
    }

    public void LoadScene1()
    {
        SceneManager.LoadScene("version_no_enviromental");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("version_enviromental");
    }
}
