using UnityEngine;

public class Spray_Script : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public GameObject spray;
    public ParticleSystem spraying;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot()
    {
        spraying.Play();

        RaycastHit hit;

        if (Physics.Raycast(spray.transform.position, spray.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            SprayTarjet_Script target = hit.transform.GetComponent<SprayTarjet_Script>();
            if( target != null)
            {
                target.paintOnWall(damage);
            }
        };
    }
}
