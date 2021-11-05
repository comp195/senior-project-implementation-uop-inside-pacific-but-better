using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = transform.Find("Tab Delete").GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        Debug.Log("tab should be deleted");
        Destroy(this.gameObject);
    }

}
