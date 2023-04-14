using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class again : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button> ().onClick.AddListener (() => {
            ClickEvent ();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ClickEvent()
    {
        SCORE.scoreSum = 0;
        Time.timeScale = 1f;
    }
}
