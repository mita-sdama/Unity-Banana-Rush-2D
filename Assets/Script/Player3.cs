using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player3 : MonoBehaviour {
    public Text pisangText;
    private int totalPisang = 0;
    public string sceneLose;
    public string sceneName;
    // Use this for initialization
    void Start()
    {
        UpdatePisangText();

    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Banana"))
        {
            totalPisang+=20;
            UpdatePisangText();
            Destroy(hit.gameObject);
        }
        if (hit.CompareTag("water"))
        {
            Application.LoadLevel(sceneLose);
        }

    }
    private void UpdatePisangText()
    {
        string pisangMessage = "Score : " + totalPisang;
        pisangText.text = pisangMessage;

        if (totalPisang == 200)
        {
            Application.LoadLevel(sceneName);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}

