using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApontarAlvo : MonoBehaviour
{
    // Start is called before the first frame update

    //private Transform target;
    //private Vector3 difBetweenTarget;
    //private Vector3 dirToTarget;
    private GameObject Alvo;
    
    public Transform firePos;
    //private float distToTarget;
    public LayerMask alvos;
    //public SpawnerAlvo sn;
  //public Transform head;

    public float maxDistance;
    public float minDistance;
    public float rate = 0.1f;


    public GameObject bulletPrefab;

    //private void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.magenta;
    //    Gizmos.DrawRay(transform.position, difBetweenTarget);
    //    Gizmos.color = Color.green;
    //    Gizmos.DrawRay(transform.position, dirToTarget);
    //    Gizmos.color = Color.blue;
    //    Gizmos.DrawRay(transform.position, transform.forward);


    //}

    //private void Awake()
    //{
    //    player = GameObject.FindGameObjectWithTag("Alvo");


    //}
    void Start()
    {
       Alvo = GameObject.FindGameObjectWithTag("Alvo");
    }

    // Update is called once per frame
    void Update()
    {

        //difBetweenTarget = target.position - transform.position;
        //dirToTarget = difBetweenTarget.normalized;
        //distToTarget = difBetweenTarget.magnitude;

        /*
        Vector3 dif = Alvo.transform.position - head.transform.position;
        float dist = dif.magnitude;
        Vector3 dir = dif.normalized;*/
        /*
        if (dist > minDistance && dist < maxDistance)
        {
            head.transform.forward = Vector3.Slerp(head.transform.forward, dir, Time.deltaTime);
            float dot = Vector3.Dot(head.transform.forward, dir);
            if (dot > 0.8)
            {
                
                    Shoot(head.transform.forward);
                    
                

            }
        
        }*/

        if (Input.GetMouseButton(1))
        {
            Shoot(firePos.transform.forward);
        } 

       
    }

    void Shoot(Vector3 dir)
    {

        //GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, firePos.position, firePos.rotation);

        //Bullet bullet = bulletGo.GetComponent<Bullet>();

        //if(bullet != null) 
        //{
        //    //bullet.Seek(target);
        //}


       
        RaycastHit hit;
        Physics.Raycast(firePos.position, dir, out hit, maxDistance, alvos);
        if (hit.collider != null)
            //Alvo = GameObject.FindGameObjectWithTag("Alvo");
        {
            //float dot = Vector3.Dot(Alvo.transform.forward, dir);
            //if (dot > -0.8)
            //{
                if (hit.collider.gameObject.tag == "Alvo")
                {
                    //var temp = Instantiate(pfPlayerShootVFX);
                    //temp.transform.position = hit.point;
                    //temp.transform.forward = (transform.position - temp.transform.position).normalized;
                    Debug.Log("Acertou");
                    
                    //sn.GetComponent<SpawnerAlvo>().Destruir();
                    Debug.Log("Acertouvvvvvvvvvvv");


                }
            //}
            else
            {
                //var temp = Instantiate(pfMissShootVFX);
                //temp.transform.position = hit.point;
                //temp.transform.forward = Vector3.up;
                Debug.Log("Falhou");
            }
            //Debug.Log(hit.collider.gameObject.name);
        }

    }
}
