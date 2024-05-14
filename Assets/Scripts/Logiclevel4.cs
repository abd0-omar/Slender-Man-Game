using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logiclevel4 : MonoBehaviour
{
    public GameObject counter;
    public GameObject counter2;

    public int pageCount;
    public string level5;
    public int maxParrotCountForLevel;
    public int parrotCounts;


    void Start()
    {
        pageCount = 0;
        parrotCounts = 0;
        maxParrotCountForLevel = 2;
        Pathfinding.parrotCount = maxParrotCountForLevel;
    }


    void Update()
    {
        counter.GetComponent<Text>().text = pageCount + "/8";
        counter2.GetComponent<Text>().text = parrotCounts + "/2";

        if (pageCount == 8)
        {
            SceneManager.LoadScene(level5);
        }
    }
}
