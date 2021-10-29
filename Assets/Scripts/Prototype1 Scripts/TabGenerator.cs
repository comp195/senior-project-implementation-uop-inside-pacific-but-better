using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabGenerator : MonoBehaviour
{
    [SerializeField] private GameObject tabPrefab;
  
    // Start is called before the first frame update
    void Start()
    {
    }

    public void CreateTab()
    {
        GameObject t = (GameObject) Instantiate(tabPrefab, RandomCords(), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
    }

    public Vector2 RandomCords()
    {
        Vector2 tabPos = transform.position;
        tabPos.x = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
        tabPos.y = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        return tabPos;
    }
}
