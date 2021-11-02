using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Prototype2AcademicPageTabs : MonoBehaviour
{
    public GameObject page1, page2, page3, page4, page5, page6, page7, page8, page9;
    public GameObject parent, AcademicServicesParent, FinancialAidLinksParent, currentSelectedGameObject;
    public Dictionary<string, GameObject> dict = new Dictionary<string, GameObject>();
    public bool updateDict = true;

    public Dictionary<string, GameObject> AcademicServicesDict = new Dictionary<string, GameObject>();
    public GameObject AcademicServicesPage1, AcademicServicesPage2, AcademicServicesPage3;

    public Dictionary<string, GameObject> FinancialAidLinksDict = new Dictionary<string, GameObject>();
    public GameObject FinancialAidLinksPage1, FinancialAidLinksPage2, FinancialAidLinksPage3, FinancialAidLinksPage4,
        FinancialAidLinksPage5, FinancialAidLinksPage6;

    // Update is called once per frame
    void Update()
    {
        if (updateDict == true)
        {
            updateDict = false;
            // For the pages that correspond to the top most row of buttons on the Academic page
            dict.Add("Academic Services Button", page1);
            dict.Add("Manage Your Account Button", page2);
            dict.Add("Financial Aid Links Button", page3);
            dict.Add("Academic Links Button", page4);
            dict.Add("Course Evaluations Button", page5);
            dict.Add("National Student Clearinghouse Button", page6);
            dict.Add("Follett Bookstore Button", page7);
            dict.Add("Course Syllabi Repository Button", page8);
            dict.Add("LinkedIn Learning Button", page9);
            // For the pages that correspond to the academic services button
            AcademicServicesDict.Add("Personal Information Button", AcademicServicesPage1);
            AcademicServicesDict.Add("Financial Aid Button", AcademicServicesPage2);
            AcademicServicesDict.Add("Student Services Button", AcademicServicesPage3);
            // For the pages that correspond to the financial aid links button
            FinancialAidLinksDict.Add("Financial Aid Links Button", FinancialAidLinksPage1);
            FinancialAidLinksDict.Add("Eligibility Button", FinancialAidLinksPage2);
            FinancialAidLinksDict.Add("View Your Financial Aid Award Button", FinancialAidLinksPage3);
            FinancialAidLinksDict.Add("View Federal Work Study Button", FinancialAidLinksPage4);
            FinancialAidLinksDict.Add("Additional Financial Aid Information Button", FinancialAidLinksPage5);
            FinancialAidLinksDict.Add("E-mail Pacific Button", FinancialAidLinksPage6);
        }
    }

    // REMEMBER TO RELACE THE DICTIONARY AND PARENT WHEN DUPLICATING FUNCTIONS
    public void loopChildren()
    {
        // Loops through all children within the parent the button was pressed.
        // Hide every page that's not corresponding to the button (specified in the dictionary declatations).
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

    public void loopChildrenAcademicServices()
    {
        // Loops through all children within the parent the button was pressed.
        // Hide every page that's not corresponding to the button (specified in the dictionary declatations).
        for (int i = 0; i < AcademicServicesParent.transform.childCount; i++)
        {
            //Debug.Log(parent.transform.GetChild(i).name);
            string converted = AcademicServicesParent.transform.GetChild(i).name;
            string name = EventSystem.current.currentSelectedGameObject.name;
            //Debug.Log(dict.ContainsKey(name));
            AcademicServicesDict.TryGetValue(name, out GameObject temp);

            //Debug.Log(converted);
            //Debug.Log(temp.transform.name);

            if (converted == temp.transform.name)
            {
                temp.SetActive(true);
            }
            else if (converted != temp.transform.name)
            {
                AcademicServicesParent.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    public void loopChildrenFinancialAidLinks()
    {
        // Loops through all children within the parent the button was pressed.
        // Hide every page that's not corresponding to the button (specified in the dictionary declatations).
        for (int i = 0; i < FinancialAidLinksParent.transform.childCount; i++)
        {
            //Debug.Log(parent.transform.GetChild(i).name);
            string converted = FinancialAidLinksParent.transform.GetChild(i).name;
            string name = EventSystem.current.currentSelectedGameObject.name;
            //Debug.Log(dict.ContainsKey(name));
            FinancialAidLinksDict.TryGetValue(name, out GameObject temp);

            //Debug.Log(converted);
            //Debug.Log(temp.transform.name);

            if (converted == temp.transform.name)
            {
                temp.SetActive(true);
            }
            else if (converted != temp.transform.name)
            {
                FinancialAidLinksParent.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
