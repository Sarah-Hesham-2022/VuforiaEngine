using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void Continue(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
