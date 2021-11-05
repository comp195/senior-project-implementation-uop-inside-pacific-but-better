using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabGenerator : MonoBehaviour
{
    [SerializeField] private GameObject tabPrefab;
    public List<GameObject> tabs;
  
    // Start is called before the first frame update
    void Start()
    {
        tabs = new List<GameObject>();
    }

    public void CreateTab()
    {
        GameObject t = (GameObject) Instantiate(tabPrefab, RandomCords(), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        tabs.Add(t);
    }

    public void RemoveTabFromList(GameObject tab)
    {
        tabs.Remove(tab);
    }

    public Vector2 RandomCords()
    {
        Vector2 tabPos = transform.position;
        tabPos.x = Random.Range(90,110);
        tabPos.y = Random.Range(90,110);
        return tabPos;
    }

    public List<GameObject> GetTabList()
    {
        return tabs;
    }
}
