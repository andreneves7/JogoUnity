using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 15f;
    private bool m_shoot;

    public Camera fpsCam;
    public ParticleSystem muzzelFlash;
    public GameObject impactEfect;
    public GameObject impactEfectFail;
    public GameObject impactEfectFailParede;
   


    public float nextTimeToFire = 0f;
    
    public void shooting()
    {
        if (!m_shoot)
        {
            m_shoot = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (m_shoot == true)
        {
            m_shoot = Input.GetButton("Fire1");
            

            if (Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;

                Shoot();
            }
        }
    }

    void Shoot()
    {
        muzzelFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.tag);   

            Target target = hit.transform.GetComponent<Target>();


            if (hit.collider.CompareTag("Mapa"))
            {
                GameObject impactGO3 = Instantiate(impactEfectFailParede, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO3, 2f);
                Debug.Log("Cheguei");

            }

            else if (hit.collider.CompareTag("Limites"))
            {
             
                Debug.Log("Cheguei limite");

            }
            else
            {
                if (target != null)
                {
              
              
                    target.TakeDamage(damage);
                    GameObject impactGO = Instantiate(impactEfect, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(impactGO, 2f);
                    Debug.Log(damage);
                }
                else
                {

                    GameObject impactGO2 = Instantiate(impactEfectFail, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(impactGO2, 2f);


                }

            }

            


        }
    }
}
