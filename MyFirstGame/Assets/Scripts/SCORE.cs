using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORE : MonoBehaviour
{
    //要產生的canvas
    public GameObject canvasPrefab;
     //宣告分數參數

    public static int scoreSum;

    //宣告文字UI

    public Text showScore;

    // Start is called before the first frame update
    void Start()
    {
        scoreSum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //讓UI文字與分數同步
        showScore.text = scoreSum.ToString();
        /*
        if(scoreSum == 50)
        {
            sscore();
        }
        */
    }

    void sscore()
    {
        //生產canvasPrefab
        Instantiate (canvasPrefab, Vector2.zero, Quaternion.identity);
        Time.timeScale = 0f;
    }
}
