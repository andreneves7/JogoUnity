using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApontarAlvo : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;
    private Vector3 difBetweenTarget;
    private Vector3 dirToTarget;
    private GameObject player;
    public Transform firePos;
    private float distToTarget;
  public Transform head;

    public float maxDistance;
    public float minDistance;
    public float rate = 0.1f;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawRay(transform.position, difBetweenTarget);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, dirToTarget);
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, transform.forward);
       

    }

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Alvo");
        

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        difBetweenTarget = target.position - transform.position;
        dirToTarget = difBetweenTarget.normalized;
        distToTarget = difBetweenTarget.magnitude;


        Vector3 dif = player.transform.position - head.transform.position;
        float dist = dif.magnitude;
        Vector3 dir = dif.normalized;

        if (dist > minDistance && dist < maxDistance)
        {
            head.transform.forward = Vector3.Slerp(head.transform.forward, dir, Time.deltaTime);
            float dot = Vector3.Dot(head.transform.forward, dir);
            if (dot > 0.8)
            {
                
                    Shoot(head.transform.forward);
                    
                

            }

        }

    }

    void Shoot(Vector3 dir)
    {
        
       
        RaycastHit hit;
        Physics.Raycast(firePos.position, dir, out hit, maxDistance);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject == player)
            {
                //var temp = Instantiate(pfPlayerShootVFX);
                //temp.transform.position = hit.point;
                //temp.transform.forward = (transform.position - temp.transform.position).normalized;
                Debug.Log("Fodeu");
            }
            else
            {
                //var temp = Instantiate(pfMissShootVFX);
                //temp.transform.position = hit.point;
                //temp.transform.forward = Vector3.up;
                Debug.Log("Putas");
            }
            //Debug.Log(hit.collider.gameObject.name);
        }

    }
}
