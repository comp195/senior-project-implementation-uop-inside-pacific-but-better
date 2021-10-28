using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogOut : MonoBehaviour
{
    [SerializeField] private GameObject logOutButton;
    // Start is called before the first frame update

    public void LogOutofIPBB()
    {
        SceneManager.LoadScene(sceneName: "MainSelection");
    }
}
