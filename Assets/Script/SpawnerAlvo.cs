using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAlvo : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;


    [SerializeField]
    private Transform[] transforms; //game objects vazios

    public bool Sequential = false;
    public float timeBetweenTargets = 0.1f;
    public int currentTarget = 0;


    IEnumerator SpawnSequential(int id)
    {

        var temp = Instantiate(prefab);
        temp.transform.position = transforms[id].position;
        temp.transform.rotation = transforms[id].rotation;
        yield return new WaitForSeconds(timeBetweenTargets);
        currentTarget++;
        if (id < transforms.Length - 2)
            StartCoroutine("SpawnSequential", currentTarget);
       
    }

    void OnTriggerEnter(Collider other)
    {
        while(currentTarget >= 0)
        {

      
        if (!Sequential)
        {
            foreach (var tf in transforms)
            {
                var temp = Instantiate(prefab);
                temp.transform.position = tf.position;
                temp.transform.rotation = tf.rotation;
                    currentTarget--;
            }

        }

        else
        {
            StartCoroutine("SpawnSequential", currentTarget);

        }
        }
    }
}
