using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void ChangeScene2()
    {
        SceneManager.LoadScene("Scene1");
    }
}
