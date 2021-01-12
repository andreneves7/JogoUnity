using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAlvo : MonoBehaviour
{
    //public GameObject depoletar;
    //Collider play;

   
    //IEnumerator AlvoAparecer()
    //{
       
    //    yield return null;

    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    //StartCoroutine(AlvoAparecer());
    //    var temp = Instantiate(depoletar);

    //    temp.transform.position = new Vector3(-4.41f, 0.01f, -13.25f);


    //    temp.transform.Rotate(0f, 90.0f, 0f);
       


    //    play.gameObject.SetActive(false);

    //}




    // Start is called before the first frame update
    void Start()
    {
       //play = GetComponent<Collider>();
       // play.isTrigger = true;

       // Debug.Log("Trigger On : " + play.isTrigger);
        //x.Add(new Vector3(-3.13f, 0.06f, -6.87f));
       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destruir()
    {
        Destroy(gameObject);
    }
    

   

}
