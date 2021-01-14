using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //public GameObject menu;

    public void StartGame()
    {
        SceneManager.LoadScene("Niveis");
    }
    public void GameLevel1()
    {
        SceneManager.LoadScene("Game");
    }
    public void GameLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

    //public void Pausa()
    //{

    //    menu.SetActive(true);
    //    Time.timeScale = 0f;
    //    Debug.Log("ola");

    //}
    public void QuitGame()
    {
        SceneManager.LoadScene("Menu"); 
    }

    //    public void ReturnGame()
    //    {
    //    menu.SetActive(false);
    //    Time.timeScale = 1f;
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape)){
        //    Pausa();
        //} 
    }
}
