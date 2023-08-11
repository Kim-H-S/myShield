using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    public GameObject endPanel;
    public Text timeTxt;

    float alive = 0f;

    public static gameManager I;

    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        timeTxt.text = alive.ToString("N2");
    }

    void makeSquare()
    {
        Instantiate(square);
    }

    public void gameOver()
    {
        Time.timeScale = 0;
        endPanel.SetActive(true);
    }
}
