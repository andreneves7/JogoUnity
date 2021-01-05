using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public KeyCode p = KeyCode.M;

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void PauseGame()
    {
        //if (Input.GetKeyDown(RunKey))
        //{

           SceneManager.LoadScene("Pausa");
       // }
    }
    public void ReturnGame()
    {
        SceneManager.LoadScene("Menu"); 
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(p))
        {

            SceneManager.LoadScene("Pausa");
        }
    }
}
