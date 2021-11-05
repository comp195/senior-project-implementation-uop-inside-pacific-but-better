using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabToggle : MonoBehaviour
{
    private TabGenerator tabs;
    // Start is called before the first frame update
    void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Canvas");
        tabs = temp.GetComponent<TabGenerator>();
        Button btn = transform.Find("Tab Delete").GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        Debug.Log("tab should be deleted");
        tabs.RemoveTabFromList(this.gameObject);
        Destroy(this.gameObject);
    }

}
