using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountDown : MonoBehaviour
{
    public GameObject textDisplay;

    private bool i = false;
    public bool b = false;
   
    public int secondsLeft = 30;
    public bool takingAway = false;

    void Start()
    {
        b = SpawnerAlvo.inicio;
        i = UpdateInfoJogo.fim;
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        Debug.Log(b);
    }

    void Update()
    {
        b = SpawnerAlvo.inicio;
        i = UpdateInfoJogo.fim;
        Debug.Log(i);

        if ( b == true)
        {

       
            if (takingAway == false && secondsLeft > 0 && i == false)
            {
                StartCoroutine(TimerTake());
            }
            else if ( secondsLeft == 0)
            {
                SceneManager.LoadScene("Game");

            }
           

        }




    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft--;
        if (secondsLeft < 10)
        {
            textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        }
        takingAway = false;
    }


}
