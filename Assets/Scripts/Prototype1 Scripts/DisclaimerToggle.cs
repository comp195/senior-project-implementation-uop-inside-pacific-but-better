using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisclaimerToggle : MonoBehaviour
{
    [SerializeField] private GameObject disclaimer;
    // Start is called before the first frame update
    void Start()
    {
        disclaimer.SetActive(false);
    }

    public void ShowDisclaimer()
    {
        disclaimer.SetActive(true);
    }

    public void HideDisclaimer()
    {
        disclaimer.SetActive(false);
    }
}
