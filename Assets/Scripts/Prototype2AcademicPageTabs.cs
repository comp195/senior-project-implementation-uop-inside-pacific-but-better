using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Prototype2AcademicPageTabs : MonoBehaviour
{
    public GameObject page1, page2, page3, page4, page5, page6, page7, page8, page9;
    public GameObject parent, currentSelectedGameObject;
    public Dictionary<string, GameObject> dict = new Dictionary<string, GameObject>();
    public bool updateDict = true;

    // Update is called once per frame
    void Update()
    {
        if (updateDict == true)
        {
            updateDict = false;
            dict.Add("Academic Services Button", page1);
            dict.Add("Manage Your Account Button", page2);
            dict.Add("Financial Aid Links Button", page3);
            dict.Add("Academic Links Button", page4);
            dict.Add("Course Evaluations Button", page5);
            dict.Add("National Student Clearinghouse Button", page6);
            dict.Add("Follett Bookstore Button", page7);
            dict.Add("Course Syllabi Repository Button", page8);
            dict.Add("LinkedIn Learning Button", page9);
        }
    }

    public void loopChildren()
    {
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            //Debug.Log(parent.transform.GetChild(i).name);
            string converted = parent.transform.GetChild(i).name;
            string name = EventSystem.current.currentSelectedGameObject.name;
            //Debug.Log(dict.ContainsKey(name));
            dict.TryGetValue(name, out GameObject temp);

            //Debug.Log(converted);
            //Debug.Log(temp.transform.name);

            if (converted == temp.transform.name)
            {
                temp.SetActive(true);
            }
            else if (converted != temp.transform.name)
            {
                parent.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
