using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrototypeSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectOne()
    {
        SceneManager.LoadScene(sceneName: "Prototype1");
    }

    public void SelectTwo()
    {
        SceneManager.LoadScene(sceneName: "Prototype2.1");
    }
}
