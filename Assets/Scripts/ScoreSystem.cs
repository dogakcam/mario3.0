using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreSystem : MonoBehaviour
{
    public GameObject ScoreText;
    public static int theScore;

    // Update is called once per frame
    void Update()
    {
        ScoreText.GetComponent<Text>().text = "Coin: " + theScore;
    }
}
