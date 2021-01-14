using UnityEngine;

public class Target : MonoBehaviour
{
    public float healf = 50f;
    [SerializeField]
   private Transform target;
    private int waypointIndex = 0;
    public float speed = 3f;
    public bool canMove = false;

    public void SetTarget(int [] ids)
    {
        waypointIndex = ids[Random.Range(0,ids.Length)];
    }

    void Start()
    {
        target = WayPoint.waypoint[waypointIndex];
    }

    void Update()
    {
        if (canMove == true)
        {
            Vector3 dir = target.position - transform.position;
            //transform.LookAt(dir + transform.position);
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
            if (Vector3.Distance(transform.position, target.position) <= 0.1f)
            {
                nextWayPoint();
            }
        }
       
    }


    public void TakeDamage(float amout)
    {
        healf -= amout;
        if (healf == 0f)
        {
            Die();
        }
    }

    void Die()
    {

        Debug.Log(inicio.total);
        Destroy(gameObject);
        SpawnerAlvo.numeroDeAlvosNoNivel--;
        inicio.total--;
       
    }


    void nextWayPoint()
    {
        if (waypointIndex == 1)
        {
            waypointIndex--;
            target = WayPoint.waypoint[waypointIndex];
        }
        else if (waypointIndex == 0)
        {
            waypointIndex++;
            target = WayPoint.waypoint[waypointIndex];
        }
        //waypointIndex++;
        //target = WayPoint.waypoint[waypointIndex];

    }
}
