using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAlvo : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;


    [SerializeField]
    private Transform[] transforms; //game objects vazios

    public static bool inicio = false;
   

    public bool Sequential = false;
    public float timeBetweenTargets = 0.1f;
    public int currentTarget = 0;
    public static int numeroDeAlvosNoNivel = 0;
    public int[] targets;
    public bool move = false;
    public bool wesSpawn = false;


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
        
        if (wesSpawn) { return; }
        while(currentTarget >= 0)
        {

      
          if (Sequential == false)
          {
            foreach (var tf in transforms)
            {
                var temp = Instantiate(prefab);
                temp.GetComponent<Target>().canMove = move;

                    if (move == true)
                    {
                        temp.transform.position = tf.position;
                        temp.transform.rotation = tf.rotation;
                        numeroDeAlvosNoNivel++;
                        temp.GetComponent<Target>().SetTarget(targets);
                        currentTarget--;
                    }
                    else
                    {

                        temp.transform.position = tf.position;
                        temp.transform.rotation = tf.rotation;
                        currentTarget--;
                        numeroDeAlvosNoNivel++;
                        inicio = true;
                    }
                
            }
                

          }
            wesSpawn = true;
            //else
            //{
            //  StartCoroutine("SpawnSequential", currentTarget);

            //}
        }
    }
}
