using UnityEngine;

public class Target : MonoBehaviour
{
    public float healf = 50f;
   private Transform target;
    private int waypointIndex = 0;
    public float speed = 3f;

    void Start()
    {
        target = WayPoint.waypoint[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
       //transform.LookAt(dir + transform.position);
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
        {
            nextWayPoint();
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
        
        Destroy(gameObject);
    }


    void nextWayPoint()
    {
        //if (waypointIndex == 1)
        //{
        //    waypointIndex--;
        //    target = WayPoint.waypoint[waypointIndex];
        //}
        //else if (waypointIndex == 0)
        //{
        //    waypointIndex++;
        //    target = WayPoint.waypoint[waypointIndex];
        //}
        waypointIndex++;
        target = WayPoint.waypoint[waypointIndex];

    }
}
