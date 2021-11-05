using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TabInput : MonoBehaviour
{
    public string tabName;
    public TMP_InputField input;
    public TextMeshProUGUI output;
    public Button enter;
    // Start is called before the first frame update
    void Start()
    {
        input = transform.Find("Tab Naming").GetComponent<TMP_InputField>();
        output = transform.Find("Tab UserName").GetComponent<TextMeshProUGUI>();
        enter = transform.Find("Tab Enter Button").GetComponent<Button>();
        enter.onClick.AddListener(SaveName);
        //Debug.Log(input.placeholder);
    }

    public void SaveName()
    {
        tabName = input.text;
        output.text = tabName;
    }
}
