using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogOut : MonoBehaviour
{
    [SerializeField] private GameObject logOutButton, Prototype2DashBoardButton;
    // Start is called before the first frame update

    public void LogOutofIPBB()
    {
        SceneManager.LoadScene(sceneName: "MainSelection");
    }

    // Prototype 1 Functions

    // Prototype 2 Functions
    public void Prototype2Dashboard()
    {
        SceneManager.LoadScene(sceneName: "Prototype2.1");
    }
    public void Prototype2Academic()
    {
        SceneManager.LoadScene(sceneName: "Prototype2.1-Academic");
    }
}
