using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UpdateInfoJogo : MonoBehaviour
{

    public TextMeshProUGUI myText;
    public int nextSceneLoad;
    public static bool fim = false;
   
    // Start is called before the first frame update
    void Start()
    {
        fim = false;
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
      
    }

    // Update is called once per frame
    void Update()
    {
       
       myText.text = $"{SpawnerAlvo.numeroDeAlvosNoNivel}";
        if(inicio.total == 0)
        {
            fim = true;
            //SceneManager.LoadScene("Level2");
           SceneManager.LoadScene(nextSceneLoad);
            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt") )
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }


        }
    }
}
