using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SearchBarController : MonoBehaviour
{
    [SerializeField] private GameObject tabList;
    private TMP_InputField inputField;
    private TabGenerator tabs;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
        GameObject temp = GameObject.FindGameObjectWithTag("Canvas");
        tabs = temp.GetComponent<TabGenerator>();
    }

    public void SearchTab()
    {
        List<GameObject> t = tabs.GetTabList();
        foreach (GameObject tab in t)
        {
            if (inputField.text != tab.GetComponent<TabInput>().GetName())
            {
                tab.SetActive(false);
            }
            if (inputField.text == "")
            {
                tab.SetActive(true);
            }
        }
    }
}
