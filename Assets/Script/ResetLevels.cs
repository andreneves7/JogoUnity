using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLevels : MonoBehaviour
{
    public bool reset = false;
    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerPrefs.DeleteAll();
        }
        reset = UpdateInfoJogo.fimNiveis;
        if (reset == true)
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
